using System;

namespace ContactsList
{
  class Friend : Contact
  {
    public string EmailAddress {get; set; }
    public Friend(string firstName, string lastName, string address, string phoneNumber, string emailAddress) :
      base(firstName, lastName, address, phoneNumber)
    {
      EmailAddress = emailAddress;

    }

    public override string ToString()
    {
      return String.Format(
        "Name: {0} {1}\nAddress: {2}\nPhone: {3}\nEmail: {4}\n\n",
        FirstName, LastName, Address, PhoneNumber, EmailAddress);
      }
  }
}
