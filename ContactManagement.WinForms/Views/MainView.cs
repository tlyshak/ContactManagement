using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactManagement.Application.Interfaces.Presenters;
using ContactManagement.Application.Interfaces.Views;
using ContactManagement.Application.Models;
using ContactManagement.WinForms.Controls;
using ContactManagement.WinForms.Helpers;
using ContactManagement.WinForms.Services;
using ContactManagement.WinForms.Ui;

namespace ContactManagement.WinForms.Views
{
    public partial class MainView : Form, IMainView
    {
        private IMainPresenter _presenter;

        private Contact _selectedContact;
        private ContactCard _selectedCard;

        private ContactListRenderer _renderer;

        public MainView()
        {
            InitializeComponent();

            _renderer = new ContactListRenderer(flpContacts);

            Shown += (s, e) =>
            {
                InitSearchAndFiltering();
                ReloadContacts(preferredId: null);
            };

            flpContacts.Resize += (s, e) => _renderer.ResizeCards();
        }

        public void SetPresenter(IMainPresenter presenter) => _presenter = presenter;

        public void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void InitSearchAndFiltering()
        {
            cmbCategory.Items.Clear();
            cmbCategory.Items.Add("All");
            cmbCategory.Items.AddRange(Enum.GetNames(typeof(ContactCategory)));
            cmbCategory.SelectedIndex = 0;

            cmbCategory.SelectedIndexChanged += (s, e) => ReloadContacts(_selectedContact?.Id);
            txtSearch.TextChanged += (s, e) => ReloadContacts(_selectedContact?.Id);
            cmbSort.Items.AddRange(new[]
            {
                "Name A-Z",
                "Name Z-A",
                "Newest"
            });
            cmbSort.SelectedIndex = 0;
        }

        private void ReloadContacts(int? preferredId)
        {
            var category = cmbCategory.SelectedItem?.ToString() ?? "All";

            var contacts = _presenter.GetContacts(txtSearch.Text, category, cmbSort.Text);

            _renderer.Render(contacts, Card_ContactSelected, btnDeleteIcon_Click);

            if (contacts.Count == 0)
            {
                SetSelection(null, null);
                Clear();
                SetActionsEnabled(false);
                return;
            }

            var toSelect = preferredId.HasValue
                ? contacts.FirstOrDefault(x => x.Id == preferredId.Value)
                : null;

            if (toSelect == null) toSelect = contacts[0];

            SelectById(toSelect.Id);
        }

        private void Card_ContactSelected(object sender, ContactEventArgs e)
        {
            if (!(sender is ContactCard card)) return;

            SetSelection(card.Contact, card);
            Bind(card.Contact);
            SetActionsEnabled(card.Contact != null);
        }

        private void SelectById(int id)
        {
            var card = _renderer.FindCardByContactId(id) ?? _renderer.GetFirstCard();
            if (card == null)
            {
                SetSelection(null, null);
                Clear();
                SetActionsEnabled(false);
                return;
            }

            SetSelection(card.Contact, card);
            Bind(card.Contact);
            SetActionsEnabled(true);
        }

        private void SetSelection(Contact contact, ContactCard card)
        {
            _renderer.ApplySelection(ref _selectedCard, card);
            _selectedContact = contact;
        }

        private void SetActionsEnabled(bool enabled)
        {
            btnEditIcon.Enabled = enabled;
            btnDeleteIcon.Enabled = enabled;
        }

        private void Clear()
        {
            lblFullName.Text = "Select a contact";
            lblSubtitle.Text = "";

            lblPhoneValue.Text = "—";
            lblEmailValue.Text = "—";
            lblCompanyValue.Text = "—";
            lblWebsiteValue.Text = "—";
            lblNotesValue.Text = "—";
            lblAddressValue.Text = "—";

            if (pbAvatar != null)
                pbAvatar.Image = null;
        }

        private void Bind(Contact c)
        {
            if (c == null)
            {
                Clear();
                return;
            }

            lblFullName.Text = c.FullName;
            lblSubtitle.Text = c.Category.ToString();

            lblPhoneValue.Text = ShowOrDash(c.Phone);
            lblEmailValue.Text = ShowOrDash(c.Email);
            lblCompanyValue.Text = ShowOrDash(c.Company);
            lblWebsiteValue.Text = ShowOrDash(c.Website);
            lblNotesValue.Text = ShowOrDash(c.Notes);
            lblAddressValue.Text = ShowOrDash(c.Address);
            pbAvatar.Image = ImageHelper.LoadAvatar(c.AvatarPath);
        }

        private static string ShowOrDash(string value)
        {
            return string.IsNullOrWhiteSpace(value) ? "—" : value;
        }

        private void btnDeleteIcon_Click(object sender, EventArgs e)
        {
            if (_selectedContact == null) return;

            if (MessageBox.Show("Delete this contact?", "Confirm",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            _presenter.RemoveContact(_selectedContact.Id);
            ReloadContacts(preferredId: null);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var dlg = new ContactEditorForm())
            {
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    _presenter.AddContact(dlg.ResultContact);
                    ReloadContacts(preferredId: null);
                }
            }
        }

        private void btnEditIcon_Click(object sender, EventArgs e)
        {
            if (_selectedContact == null) return;

            using (var dlg = new ContactEditorForm(_selectedContact))
            {
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    _presenter.UpdateContact(dlg.ResultContact);
                    ReloadContacts(preferredId: dlg.ResultContact.Id);
                }
            }
        }

        private async void btnCsvExport_Click(object sender, EventArgs e)
        {
            var search = txtSearch.Text;
            var category = cmbCategory.SelectedItem?.ToString() ?? "All";

            var contacts = _presenter.GetContacts(search, category, cmbSort.Text);

            if (contacts == null || contacts.Count == 0)
            {
                MessageBox.Show("No contacts to export.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var dlg = new SaveFileDialog())
            {
                dlg.Filter = "CSV (*.csv)|*.csv";
                dlg.FileName = "contacts.csv";

                if (dlg.ShowDialog() != DialogResult.OK)
                    return;

                btnCsvExport.Enabled = false;

                await Task.Run(() => CsvExportService.Export(dlg.FileName, contacts));

                btnCsvExport.Enabled = true;

                MessageBox.Show("Export completed.");
            }
        }

        private void cmbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReloadContacts(null);
        }
    }
}
