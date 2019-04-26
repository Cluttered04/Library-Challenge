using System;

namespace classes_challenge
{
    class Program
    {
        static void Main(string[] args)
        {

            Library east = new Library();
            east.id = 1;
            east.name = "East";
            east.address = "123 East Street";

            Library west = new Library();
            west.id = 2;
            west.name = "West";
            west.address = "123 West Street";

            Patron bobby = new Patron();
            bobby.id = 1;
            bobby.firstName = "Bobby";
            bobby.lastName = "Bobby";
            bobby.library = west;
            bobby.overdueFees = .50;

            Patron matt = new Patron();
            matt.id = 2;
            matt.firstName = "Matt";
            matt.lastName = "Matt";
            matt.library = east;
            matt.overdueFees = 2.00;

            Librarian sable = new Librarian();
            sable.id = 1;
            sable.firstName = "Sable";
            sable.lastName = "Sable";

            Librarian sydney = new Librarian();
            sydney.id = 2;
            sydney.firstName = "Sydney";
            sydney.lastName = "Sydney";

            Book eyeOfTheWorld = new Book();
            eyeOfTheWorld.id = 1;
            eyeOfTheWorld.title = "Eye of the World";
            eyeOfTheWorld.author = "Robert Jordan";

            Book oathbringer = new Book();
            oathbringer.id = 2;
            oathbringer.title = "Oathbringer";
            oathbringer.author = "Brandon Sanderson";


            sable.checkOutBook(oathbringer, east, bobby);
            bobby.checkedOutBooks.Add(oathbringer);
            sable.returnBook(oathbringer, east, bobby);









        }
    }
}
