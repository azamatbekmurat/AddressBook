using System.Collections.Generic;
using System;

namespace AddressBook.Models
{
  public class Contact
  {
    private string _name;
    private string _phone;
    private int _id;
    private static int _counter = 1;
    private Address _address;

    private static List<Contact> _instances = new List<Contact> {};

    public Contact(string Name, string phoneNumber, Address addressDetails)
    {
      _name = Name;
      _phone = phoneNumber;
      _address = addressDetails;
      _id = _counter++;
    }

    public string GetName()
    {
      return _name;
    }
    public string GetPhone()
    {
      return _phone;
    }
    public Address GetAddress()
    {
      return _address;
    }
    public static List<Contact> GetAll()
    {
      return _instances;
    }
    public void Save()
    {
      _instances.Add(this);
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}
