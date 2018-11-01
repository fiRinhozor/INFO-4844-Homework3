using System;

namespace ContactsList
{
  class Contact
  {
    const string defaultString = "default";
    private string _firstName;
    public string FirstName 
    {
      get
    {
      return this._firstName;
    }
      set
      {
        this._firstName = !string.IsNullOrEmpty(value) ? value : defaultString;
      }
    }

    private string _lastName;
    public string LastName 
    {
      get
      {
        return this._lastName;
      }
      set
      {
        this._lastName = !string.IsNullOrEmpty(value) ? value : defaultString;
      }
    }
      
    public string Address {get; set;}
    public string PhoneNumber {get; set;}


    // Constructor; creates a new instance
    public Contact(string firstName, string lastName, string address, string phoneNumber)
    {
      FirstName = firstName;
      LastName = lastName;
      Address = address;
      PhoneNumber = phoneNumber;
    }

    // This ensures that you can print the information related to a contact
    // simply by saying Console.WriteLine(contact)
    // ToString() belongs to the Object class, which is the superclass of every
    // other class in C#.
    // You will need to override this in the subclasses (i.e., specializations)
    // to display additional information.
    public override string ToString()
    {
      return String.Format(
        "Name: {0} {1}\nAddress: {2}\nPhone: {3}\n\n",
        FirstName, LastName, Address, PhoneNumber);
      }
  }
}
