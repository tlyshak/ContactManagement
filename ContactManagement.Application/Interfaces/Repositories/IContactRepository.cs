using System.Collections.Generic;
using ContactManagement.Application.Models;

namespace ContactManagement.Application.Interfaces.Repositories
{
    public interface IContactRepository
    {
        IList<Contact> GetContacts(string search, string category, string sort);
        void RemoveContact(int id);
        int CreateContact(Contact contact);
        void UpdateContact(Contact contact);
    }
}
