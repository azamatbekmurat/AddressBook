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
    private static int lastId = 1;

    public Contact(string Name, string phoneNumber, Address addressDetails)
    {
      _name = Name;
      _phone = phoneNumber;
      _address = addressDetails;
      _id = lastId++;
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
      Console.WriteLine("Deleting"+cntId);
      var toDelete = -1;
      for (var i=0; i<_instances.Count; i++) {
        if (_instances[i].GetID() == cntId ) {
          toDelete=i;
        }
      }
      if (toDelete!=-1) {
        _instances.RemoveAt(toDelete);
      }
    }

    public static Contact Find(int searchId)
    {
      Console.WriteLine("Searching"+searchId);
      for (var i=0; i<_instances.Count; i++) {
        if (_instances[i].GetID() == searchId ) {
          return _instances[i];
        }
      }
      return null;
    }
  }
}
  
