using System;
using System.Drawing;
using System.Windows.Forms;
using ContactManagement.Application.Models;
using ContactManagement.WinForms.Helpers;

namespace ContactManagement.WinForms.Controls
{
    public partial class ContactCard : UserControl
    {
        private bool _selected;
        private bool _hover;

        public event EventHandler<ContactEventArgs> ContactSelected;
        public event EventHandler<ContactEventArgs> DeleteRequested;

        public Contact Contact { get; private set; }

        public ContactCard()
        {
            InitializeComponent();

            Cursor = Cursors.Hand;

            HookInteractions(this);

            btnDelete.Click += btnDelete_Click;

            btnDelete.MouseEnter += (s, e) => SetHover(true);
            btnDelete.MouseLeave += (s, e) => SetHover(false);

            UpdateBackColor();
        }

        public void SetContact(Contact contact)
        {
            Contact = contact;

            lblName.Text = contact != null ? contact.FullName : "";
            lblCategory.Text = contact != null ? contact.Category.ToString() : "";
            lblEmail.Text = contact != null ? (contact.Email ?? "") : "";
            lblPhone.Text = contact != null && !string.IsNullOrWhiteSpace(contact.Phone) ? contact.Phone : "—";
            pbAvatar.Image = ImageHelper.LoadAvatar(contact.AvatarPath);
        }

        public void SetSelected(bool selected)
        {
            _selected = selected;
            UpdateBackColor();
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            SetHover(true);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            SetHover(false);
        }

        private void SetHover(bool hover)
        {
            _hover = hover;
            UpdateBackColor();
        }

        private void UpdateBackColor()
        {
            Color bg;

            if (_selected)
                bg = Color.FromArgb(220, 235, 252);
            else if (_hover)
                bg = Color.FromArgb(245, 245, 245);
            else
                bg = Color.White;

            ApplyBackColorSafe(this, bg);

            if (pnlSeparator != null)
                pnlSeparator.BackColor = Color.Gainsboro;
        }

        private void HookInteractions(Control root)
        {
            foreach (Control c in root.Controls)
            {
                if (IsActionButton(c))
                    continue;

                c.Click += Card_Click;
                c.MouseEnter += (s, e) => SetHover(true);
                c.MouseLeave += (s, e) => SetHover(false);

                c.Cursor = Cursors.Hand;

                if (c.HasChildren)
                    HookInteractions(c);
            }

            root.Click += Card_Click;
            root.MouseEnter += (s, e) => SetHover(true);
            root.MouseLeave += (s, e) => SetHover(false);
        }

        private bool IsActionButton(Control c)
        {
            return ReferenceEquals(c, btnDelete);
        }

        private void Card_Click(object sender, EventArgs e)
        {
            if (Contact == null) return;
            OnSelected();
        }

        protected virtual void OnSelected()
        {
            ContactSelected?.Invoke(this, new ContactEventArgs(Contact));
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Contact == null) return;

            DeleteRequested?.Invoke(this, new ContactEventArgs(Contact));
        }

        private void ApplyBackColorSafe(Control parent, Color color)
        {
            if (!ReferenceEquals(parent, pnlSeparator) &&
                !ReferenceEquals(parent, btnDelete))
            {
                parent.BackColor = color;
            }

            foreach (Control c in parent.Controls)
                ApplyBackColorSafe(c, color);
        }
    }
}
