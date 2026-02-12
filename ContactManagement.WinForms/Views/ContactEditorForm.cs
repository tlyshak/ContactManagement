using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ContactManagement.Application.Models;

namespace ContactManagement.WinForms.Views
{
    public partial class ContactEditorForm : Form
    {
        public Contact ResultContact { get; private set; }

        public ContactEditorForm()
        {
            InitializeComponent();

            InitCategory();
            Text = "Add Contact";
            btnSave.Text = "Add";

            btnSave.Click += btnSave_Click;
            btnCancel.Click += (s, e) => DialogResult = DialogResult.Cancel;
        }

        public ContactEditorForm(Contact existing)
        {
            InitializeComponent();

            InitCategory();
            Text = "Edit Contact";
            btnSave.Text = "Save";

            LoadFromContact(existing);

            btnSave.Click += btnSave_Click;
            btnCancel.Click += (s, e) => DialogResult = DialogResult.Cancel;
        }

        private void InitCategory()
        {
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.Items.Clear();
            cmbCategory.Items.AddRange(Enum.GetNames(typeof(ContactCategory)));
            cmbCategory.SelectedIndex = 0;
        }

        private void LoadFromContact(Contact c)
        {
            if (c == null) return;

            ResultContact = new Contact
            {
                Id = c.Id,
                CreatedAt = c.CreatedAt
            };

            txtFirstName.Text = c.FirstName;
            txtLastName.Text = c.LastName;
            txtEmail.Text = c.Email;
            txtPhone.Text = c.Phone ?? "";
            cmbCategory.SelectedItem = c.Category.ToString();

            txtCompany.Text = c.Company ?? "";
            txtWebsite.Text = c.Website ?? "";
            txtAddress.Text = c.Address ?? "";
            txtNotes.Text = c.Notes ?? "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
                return;

            var createdAt = ResultContact != null && ResultContact.CreatedAt != default(DateTime)
                ? ResultContact.CreatedAt
                : DateTime.UtcNow;

            var id = ResultContact != null ? ResultContact.Id : 0;

            ResultContact = new Contact
            {
                Id = id,
                FirstName = txtFirstName.Text.Trim(),
                LastName = txtLastName.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Phone = NormalizeOptional(txtPhone.Text),
                Category = (ContactCategory)Enum.Parse(typeof(ContactCategory), cmbCategory.SelectedItem.ToString()),
                Company = NormalizeOptional(txtCompany.Text),
                Website = NormalizeOptional(txtWebsite.Text),
                Address = NormalizeOptional(txtAddress.Text),
                Notes = NormalizeOptional(txtNotes.Text),
                CreatedAt = createdAt
            };

            DialogResult = DialogResult.OK;
            Close();
        }

        private static string NormalizeOptional(string value)
        {
            value = (value ?? "").Trim();
            return value.Length == 0 ? null : value;
        }

        private bool ValidateForm()
        {
            errorProvider1.Clear();

            bool ok = true;

            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                errorProvider1.SetError(txtFirstName, "First name is required.");
                ok = false;
            }

            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                errorProvider1.SetError(txtLastName, "Last name is required.");
                ok = false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, "Email is required.");
                ok = false;
            }
            else if (!IsValidEmail(txtEmail.Text.Trim()))
            {
                errorProvider1.SetError(txtEmail, "Invalid email format.");
                ok = false;
            }

            return ok;
        }

        private bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }
    }
}
