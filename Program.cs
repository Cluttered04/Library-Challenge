using System;
using System.Collections.Generic;

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

            Patron connor = new Patron();
            connor.id = 3;
            connor.firstName = "Connor";
            connor.lastName = "Connor";
            connor.library = west;
            connor.overdueFees = 0;

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

            List<Patron> patronList = new List<Patron>();
            patronList.Add(bobby);
            patronList.Add(matt);
            patronList.Add(connor);

            List<Library> libraryList = new List<Library>();
            libraryList.Add(east);
            libraryList.Add(west);
            sable.checkOutBook(oathbringer, east, bobby);
            bobby.checkedOutBooks.Add(oathbringer);
            sable.returnBook(oathbringer, east, bobby);


            Console.WriteLine("Please choose an option by entering the corresponding number:");
            Console.WriteLine("1. Check out book");
            Console.WriteLine("2. Return Book");
            Console.WriteLine("3. Pay overdue fees");
            Console.WriteLine("4.Print library inventory");
            Console.WriteLine("5.Print customer's loans");
            Console.WriteLine("6.Create a new book");
            Console.WriteLine("7.Create a new library location");
            Console.WriteLine("8.Register a new patron");

            int chosenOption = Convert.ToInt32(Console.ReadLine());

            //Check out a book
            if (chosenOption == 1)
            {
                Console.WriteLine("Which book would you like to check out?");
                string bookName = Console.ReadLine();
                Console.WriteLine("Which library will they check it out from ?");
                string libraryName = Console.ReadLine();
                Console.WriteLine("What is the name of the patron who is checking the book out?");
                string patronName = Console.ReadLine();

                Library currentLibrary = libraryList.Find(lib => lib.name == libraryName);
                Book currentBook = currentLibrary.currentInventory.Find(bk => bk.title == bookName);
                Patron currentPatron = patronList.Find(person => person.firstName == patronName);

                sable.checkOutBook(currentBook, currentLibrary, currentPatron);

            //Return a book
            } else if(chosenOption == 2) {
                Console.WriteLine("Which book would you like to return?");
                string bookName = Console.ReadLine();
                Console.WriteLine("Which library will they return it to?");
                string libraryName = Console.ReadLine();
                Console.WriteLine("What is the name of the patron who is returning the book?");
                string patronName = Console.ReadLine();
                Library currentLibrary = libraryList.Find(lib => lib.name == libraryName);
                Book currentBook = currentLibrary.currentInventory.Find(bk => bk.title == bookName);
                Patron currentPatron = patronList.Find(person => person.firstName == patronName);

                sable.returnBook(currentBook, currentLibrary, currentPatron);

            //Pay overdue fees
            } else if(chosenOption == 3){
                Console.WriteLine("Please enter the patron's name.");
                string patronName = Console.ReadLine();
                Console.WriteLine("Please enter the amount paid.");
                string amountPaid = Console.ReadLine();
                try {
                 Patron currentPatron = patronList.Find(person => person.firstName == patronName);
                currentPatron.overdueFees -= Convert.ToDouble(amountPaid);
                } catch(NullReferenceException){
                    Console.WriteLine("Please enter a current patron name or add a new one.");
                }


            //Print library inventory
            } else if(chosenOption == 4){
                Console.WriteLine("Please select a library.");
                string libraryName = Console.ReadLine();
                try {
                    Library currentLibrary = libraryList.Find(lib => lib.name == libraryName);
                } catch(NullReferenceException){
                    Console.WriteLine("Please enter a valid library name.");
                }


            //Print customer's loans
            } else if(chosenOption == 5){
                Console.WriteLine("Please enter a customer to see their loans");
                string patronName = Console.ReadLine();
                try {
                Patron currentPatron = patronList.Find(person => person.firstName == patronName);
                Console.WriteLine(currentPatron.overdueFees);
                } catch(NullReferenceException){
                    Console.WriteLine("Please enter a valid customer name.");
                }


            //Add a new Book
            } else if(chosenOption == 6){
                Console.WriteLine("Please enter the book's title.");
                string title = Console.ReadLine();
                Console.WriteLine("Please enter the book's author.");
                string author = Console.ReadLine();
                Book newBook = new Book();
                newBook.title = title;
                newBook.author = author;

            //Add a new library
            } else if(chosenOption == 7){
                Console.WriteLine("Please enter the library name.");
                string libraryName = Console.ReadLine();
                Console.WriteLine("Please enter the library's location");
                string libraryLocation = Console.ReadLine();
                Library newLibrary = new Library();
                newLibrary.name = libraryName;
                newLibrary.address = libraryLocation;

            //Add a new patron
            } else if(chosenOption == 8){
                Console.WriteLine("Please enter the patron's first name.");
                string patronFirstName = Console.ReadLine();
                Console.WriteLine("Please enter the patron's last name.");
                string patronLastName = Console.ReadLine();
                Console.WriteLine("Please enter the patron's library");
                string patronLibrary = Console.ReadLine();
                Library patronLibraryLocation = libraryList.Find(lib => lib.name == patronLibrary);
                Patron newPatron = new Patron();
                newPatron.firstName = patronFirstName;
                newPatron.lastName = patronLastName;
                newPatron.library = patronLibraryLocation;

            //If user enters something other than a number from 1-8
            } else {
                Console.WriteLine("Please select a valid option.");
            }
        }

    }
}

