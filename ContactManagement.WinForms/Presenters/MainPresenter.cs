using System;
using System.Collections.Generic;
using ContactManagement.Application.Interfaces.Presenters;
using ContactManagement.Application.Interfaces.Services;
using ContactManagement.Application.Interfaces.Views;
using ContactManagement.Application.Models;

namespace ContactManagement.WinForms.Presenters
{
    public class MainPresenter : IMainPresenter
    {
        private readonly IMainView _view;
        private readonly IContactService _contactService;

        public MainPresenter(IMainView view, IContactService contactService)
        {
            _view = view;
            _contactService = contactService;
        }

        public IList<Contact> GetContacts(string search, string category, string sort)
        {
            try
            {
                return _contactService.GetContacts(search, category, sort);
            }
            catch (Exception ex)
            {
                _view.ShowError("Error fetching contacts: " + ex.Message);
                return new List<Contact>();
            }
        }

        public void RemoveContact(int id)
        {
            try
            {
                _contactService.RemoveContact(id);
            }
            catch (Exception ex)
            {
                _view.ShowError("Error removing contact: " + ex.Message);
            }
        }

        public void AddContact(Contact contact)
        {
            try
            {
                _contactService.CreateContact(contact);
            }
            catch (Exception ex)
            {
                _view.ShowError("Error adding contact: " + ex.Message);
            }
        }

        public void UpdateContact(Contact contact)
        {
            try
            {
                _contactService.UpdateContact(contact);
            }
            catch (Exception ex)
            {
                _view.ShowError("Error updating contact: " + ex.Message);
            }
        }
    }
}
