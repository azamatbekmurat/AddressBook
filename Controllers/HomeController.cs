using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using AddressBook.Models;
using System;

namespace AddressBook.Controllers
{
  public class HomeController : Controller
  {
        [HttpGet("/")]
        public ActionResult Index()
        {
          List<Contact> allContacts = Contact.GetAll();
          return View(allContacts);
        }

        [HttpGet("/contacts/new")]
        public ActionResult CreateForm()
        {
          return View();
        }

        [HttpPost("/input")]
        public ActionResult Create()
        {
          Address newAddress = new Address(Request.Form["new-street"], Request.Form["new-city"], Request.Form["new-state"]);

          Contact newContact = new Contact(Request.Form["new-name"], Request.Form["new-phone"], newAddress);
          newContact.Save();

          List<Contact> allContacts = Contact.GetAll();
          return View("Index", allContacts);
        }

        [HttpGet("/{id}")]
        public ActionResult Details(int id)
        {
          Contact contact = Contact.Find(id);
          return View(contact);
        }

        [HttpPost("/contacts/delete")]
        public ActionResult DeleteAll()
        {
          Contact.ClearAll();
          return View();
        }

        [HttpPost("/contacts/deleteContact/{id}")]
        public ActionResult DeleteContact(int id)
        {
          // Con tact contactID = Contact.GetID();
          // Contact contactID =
          Contact.RemoveContact(id);
          return View();
        }

  }
}
