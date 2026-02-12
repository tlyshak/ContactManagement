using System;
using ContactManagement.Application.Models;

namespace ContactManagement.WinForms.Controls
{
    public class ContactEventArgs : EventArgs
    {
        public Contact Contact { get; }

        public ContactEventArgs(Contact contact)
        {
            Contact = contact;
        }
    }
}
