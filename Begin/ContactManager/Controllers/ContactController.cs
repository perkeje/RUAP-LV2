using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;
using ContactManager.Models;
using ContactManager.Services;

namespace ContactManager.Controllers
{
    public class ContactController : ApiController
    {
        private ContactRepository contactRepository;

        public ContactController()
        {
            this.contactRepository = new ContactRepository();
        }
        // GET: Contact
        public Contact[] Get()
        {
            return contactRepository.GetAllContacts();
        }

    }
}