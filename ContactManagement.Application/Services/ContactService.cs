using System;
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
            try
            {
                return _repository.GetContacts(search, category, sort);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void RemoveContact(int id)
        {
            try
            {
                _repository.RemoveContact(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int CreateContact(Contact contact)
        {
            try
            {
                return _repository.CreateContact(contact);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void UpdateContact(Contact contact)
        {
            try
            {
                _repository.UpdateContact(contact);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
