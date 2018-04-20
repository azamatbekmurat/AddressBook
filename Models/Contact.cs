using System.Collections.Generic;
using System;

namespace AddressBook.Models
{
  public class Contact
  {
    private string _name;
    private string _phone;
    private int _id;
    private Address _address;

    private static List<Contact> _instances = new List<Contact> {};

    public Contact(string Name, string phoneNumber, Address addressDetails)
    {
      _name = Name;
      _phone = phoneNumber;
      _address = addressDetails;
      _id = _instances.Count+1;
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
    public int GetID()
    {
      return _id;
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
    public static void RemoveContact(int cntId)
    {
      _instances.RemoveAt(cntId);
      //To reset the id value of contacts in the list
      for (int i = 0; i < _instances.Count; i++)
      {
        _instances[i]._id = i+1;
      }
    }
    public static Contact Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}
