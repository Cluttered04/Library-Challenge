using System;
using System.Collections.Generic;

namespace classes_challenge {
    class Patron : Parent{
        public int id {get; set;}
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

