using System;

namespace ContactsList
{
  class FamilyMember : Contact
  {
    public string EmergencyNumber;
    public string DateOfBirth;

    public FamilyMember(string firstName, string lastName, string address, string phoneNumber, string dateofBirth, string emergencyNumber) :
      base(firstName, lastName, address, phoneNumber)
    {
      EmergencyNumber = emergencyNumber;
      DateOfBirth = dateofBirth;
    }
    public override string ToString()
    {
      return String.Format(
        "Name: {0} {1}\nAddress: {2}\nPhone: {3}\nDate of Birth: {4}\nPhone Number: {5}\n\n",
        FirstName, LastName, Address, PhoneNumber, DateOfBirth, EmergencyNumber);
      }
  }
}
