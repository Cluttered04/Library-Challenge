using System;
using System.Collections.Generic;

namespace classes_challenge {

    class Library {
        public int id {get; set;}
        public string name {get; set;}
        public string address {get; set;}
        public List<Book> currentInventory {get; set;} = new List<Book>();
        public void printInventoryReport(Library library){
            foreach(Book book in library.currentInventory){
                Console.WriteLine($"{book.title} {book.author}");
            }
        }
    }

}

