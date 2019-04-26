using System;
using System.Collections.Generic;

namespace classes_challenge {
    class Patron {
        public int id {get; set;}
        public string firstName {get; set;}
        public string lastName {get; set;}
        public Library library {get; set;}
        public double overdueFees {get; set;}
        public List<Book> checkedOutBooks {get; set;} = new List<Book>();
        public void payOverdueFees(double payment, Patron patron){
           patron.overdueFees -= payment;
        }
        public void printLoanReport(Patron patron){
            foreach(Book singleBook in checkedOutBooks){
                Console.WriteLine($"{singleBook.title} {singleBook.author}");
            }
        }

    }
}

// Give Library a method called printInventoryReport. It should print all of the books currently at that library to the console.
// Patrons should not be able to return a book that they haven't checked out. If they try to do this, the librairan should see an error message in the console.
// If a patron tries to check out a book that's out of stock, the librarian should see an error message.
// Create a few instances of libraries, patrons, and books to test your methods.