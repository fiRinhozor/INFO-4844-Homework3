using System;
using System.Text;
using System.IO; // for StringBuilder; see below for explanation

namespace ContactsList
{
  class ListOfContacts
  {
    // Maximum number of contacts your list can hold.
    public static readonly int MAX_CONTACTS = 100;

    public Contact[] Contacts { get; }
    private int NumContacts { get; set;}

    public ListOfContacts()
    {
      Contacts = new Contact[MAX_CONTACTS];
      NumContacts = 0;
    }

    public void AddContact(Contact contact)
    {
      if (NumContacts == MAX_CONTACTS)
      {
        Console.WriteLine("Reached maximum number of contacts.");
        return;
      }

      Contacts[NumContacts] = contact;
      NumContacts++;
    }

    public Contact Search(string firstName, string lastName)
    {
      for (int index = 0; index < NumContacts; index++)
      {
        Contact contact = Contacts[index];
        if (contact.FirstName == firstName && contact.LastName == lastName)
        {
          return contact;
        }
      }

      return null;
    }

    public override string ToString()
    {
      // Create a string representing the contents of the entire list.
      // Since the number of contacts varies with time, the length of
      // what's displayed also varies.
      // Therefore, we use a StringBuilder to create the output.
      // Implementing this function ensures that you can print the entire
      // contents simply by calling Console.WriteLine(myList) where
      // myList is of type ListOfContacts
      StringBuilder stringBuilder = new StringBuilder("Contacts list:\n\n");

      for (int index = 0; index < NumContacts; index++)
      {
        stringBuilder.Append(Contacts[index]);
      }

      return stringBuilder.ToString();
    }

        public void WriteToFile()
        {
            var list = new string[Contacts.Length];
            for (int i = 0; i < Contacts.Length-1; i++)
            {
                list[i] = Contacts[i]?.ToString();
            }
            System.IO.File.WriteAllLines(@"./ContactsInfo", list);
        }

        public void ReadFromFile() {
             string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Public\TestFolder\WriteLines2.txt");
        }


  }
  
}
