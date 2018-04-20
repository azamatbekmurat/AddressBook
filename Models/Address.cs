using System.Collections.Generic;
using System;

namespace AddressBook.Models
{
  public class Address
  {
    private string _street;
    private string _city;
    private string _state;
    private int _id;

    private static List<Address> _instances = new List<Address> {};

    public Address(string streetAddress, string cityName, string stateName)
    {
      _street = streetAddress;
      _city = cityName;
      _state = stateName;
      _id = _instances.Count;
    }
    public string GetAddressInfo()
    {
      return _street + ", " + _city + ", " + _state;
    }
    public int GetID()
    {
      return _id;
    }
  }
}
