using System.Collections.Generic;
using ContactManagement.Application.Models;

namespace ContactManagement.Application.Interfaces.Presenters
{
    public interface IMainPresenter
    {
        void RemoveContact(int id);
        IList<Contact> GetContacts(string search, string category, string sort);
        void AddContact(Contact contact);
        void UpdateContact(Contact contact);
    }
}
