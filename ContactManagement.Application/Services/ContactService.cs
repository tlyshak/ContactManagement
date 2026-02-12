using System.Collections.Generic;
using ContactManagement.Application.Interfaces.Repositories;
using ContactManagement.Application.Interfaces.Services;
using ContactManagement.Application.Models;

namespace ContactManagement.Application.Services
{
    public class ContactService : IContactService
    {
        private readonly IContactRepository _repository;

        public ContactService(IContactRepository repository)
        {
            _repository = repository;
        }

        public IList<Contact> GetContacts(string search, string category, string sort)
        {
            return _repository.GetContacts(search, category, sort);
        }

        public void RemoveContact(int id)
        {
            _repository.RemoveContact(id);
        }

        public int CreateContact(Contact contact)
        {
            return _repository.CreateContact(contact);
        }

        public void UpdateContact(Contact contact)
        {
            _repository.UpdateContact(contact);
        }
    }
}
