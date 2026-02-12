using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ContactManagement.Application.Models;
using ContactManagement.WinForms.Controls;

namespace ContactManagement.WinForms.Ui
{
    public sealed class ContactListRenderer
    {
        private readonly FlowLayoutPanel _host;
        private readonly int _minCardWidth;

        public ContactListRenderer(FlowLayoutPanel host, int minCardWidth = 250)
        {
            _host = host ?? throw new ArgumentNullException(nameof(host));
            _minCardWidth = minCardWidth;
        }

        public int GetCardWidth()
        {
            int w = _host.DisplayRectangle.Width - _host.Padding.Horizontal - 5;
            return Math.Max(_minCardWidth, w);
        }

        public void Render(IList<Contact> contacts, EventHandler<ContactEventArgs> onSelected, EventHandler<ContactEventArgs> onDeleted)
        {
            if (contacts == null) throw new ArgumentNullException(nameof(contacts));
            if (onSelected == null) throw new ArgumentNullException(nameof(onSelected));

            _host.SuspendLayout();
            _host.Controls.Clear();

            int w = GetCardWidth();

            foreach (var contact in contacts)
            {
                var card = new ContactCard();
                card.SetContact(contact);
                card.Width = w;

                card.ContactSelected += onSelected;
                card.DeleteRequested += onDeleted;

                _host.Controls.Add(card);
            }

            _host.ResumeLayout();
        }

        public void ResizeCards()
        {
            int w = GetCardWidth();
            foreach (Control c in _host.Controls)
            {
                c.Width = w;
            }
        }

        public ContactCard FindCardByContactId(int contactId)
        {
            foreach (Control c in _host.Controls)
            {
                var card = c as ContactCard;
                if (card?.Contact != null && card.Contact.Id == contactId)
                    return card;
            }
            return null;
        }

        public ContactCard GetFirstCard()
        {
            if (_host.Controls.Count == 0) return null;
            return _host.Controls[0] as ContactCard;
        }

        public void ApplySelection(ref ContactCard selectedCard, ContactCard newSelectedCard)
        {
            if (selectedCard != null)
                selectedCard.SetSelected(false);

            selectedCard = newSelectedCard;

            if (selectedCard != null)
                selectedCard.SetSelected(true);
        }
    }
}
