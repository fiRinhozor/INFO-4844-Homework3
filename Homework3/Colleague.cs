using System;

namespace ContactsList
{
  class Colleague : Contact
  {
    public string CompanyName;
    public string WorkEmail;

    public Colleague(string firstName, string lastName, string address, string phoneNumber, string companyName, string workEmail) :
      base(firstName, lastName, address, phoneNumber)
    {
      CompanyName = companyName;
      WorkEmail = workEmail;
    }

    public override string ToString()
    {
      return String.Format(
        "Name: {0} {1}\nAddress: {2}\nPhone: {3}\nCompany Name: {4}\nWork Email: {5}\n\n",
        FirstName, LastName, Address, PhoneNumber, CompanyName, WorkEmail);
      }
  }
}
