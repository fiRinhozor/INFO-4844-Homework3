using System;

namespace ContactsList
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of contacts
            ListOfContacts myList = new ListOfContacts();


            // Populate the list
            myList.AddContact(new Contact(
              "Sourav", "Mukherjee", "842 Cambie Road, Vancouver, BC", "000-000-0000"));

            myList.AddContact(new Contact(
              "Jim", "Kurose", "University of Massachusetts", "111-111-1111"));

            myList.AddContact(new Contact(
              "Richard", "Sutton", "University of Alberta, Edmonton", "222-222-2222"));

            // TODO: Add additional information
              myList.AddContact(new Friend(
              "Santa", "Claus", "North Pole, H0H 0H0, Canada", "1-800-H0H-0H00", "test@gmail.com"));
              myList.AddContact(new Friend(
              "Alex", "Choi", "LA, V5T T54, USA", "1-800-666-3232", "alexchoi@gmail.com"));
              myList.AddContact(new Friend(
              "Dave", "East", "New York, V3C 3GF, USA", "1-800-555-23223", "daveeast@gmail.com"));

            // TODO: Add additional information
            myList.AddContact(new Colleague(
              "Kanye", "West", "555 Fairfax, 35243, CA", "333-555-4433", "Microsoft", "workmicrosoft@gmail.com"));
              myList.AddContact(new Colleague(
              "David", "Blane", "842 Cambie Road, Vancouver, BC", "333-333-3333", "Mobify", "mobify@gmail.com"));
              myList.AddContact(new Colleague(
              "Sergey", "Brin", "842 Cambie Road, Vancouver, BC", "222-666-888", "Google", "sbrin@gmail.com"));

            // TODO: Add additional information
            myList.AddContact(new FamilyMember(
              "Kekovich", "Nadzor", "555 Robson Street, Vancouver, BC", "1-800-6767-111", "26.09.1996", "7789082321"));
              myList.AddContact(new FamilyMember(
              "Ivan", "Ivanov", "555 Robson Street, Vancouver, BC", "1-800-6565-222", "23.10.1972", "7789200302"));
              myList.AddContact(new FamilyMember(
              "Alexa", "Amazon", "555 Robson Street, Vancouver, BC", "1-800-5656-333", "19.07.1978", "778500000"));

            // Print the contents of the contacts list
            Console.WriteLine(myList);

            // Search the list by firstName lastName combinations
            // When a match is found, display all contact information available
            // All the searches should find a match except for the last one.
            string[] firstNames = new string[]{
              "Sourav", "Jim", "Richard", "Santa", "Friendly", "Beau", "Keith"};
            string[] lastNames = new string[]{
              "Mukherjee", "Kurose", "Sutton", "Claus", "Colleague", "TheDog", "Ross"};



            for (int index = 0; index < firstNames.Length; index++)
            {
              Contact match = myList.Search(firstNames[index], lastNames[index]);
              if (match == null)
              {
                Console.WriteLine("No match found with first name: {0} and last name: {1}",
                  firstNames[index], lastNames[index]);
              }
              else
              {
                Console.WriteLine("Match found with first name: {0} and last name: {1}\n{2}",
                  firstNames[index], lastNames[index], match);

                
              }
            }

            myList.WriteToFile();
        }
    }
}
