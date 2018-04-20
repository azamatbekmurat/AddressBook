using System.Collections.Generic;
using System;

namespace AddressBook.Models
{
  public class Address
  {
    private string _street;
    private string _city;
    private string _state;

    public Address(string streetAddress, string cityName, string stateName)
    {
      _street = streetAddress;
      _city = cityName;
      _state = stateName;
    }
    public string GetAddressInfo()
    {
      return _street + ", " + _city + ", " + _state;
    }
  }
}
