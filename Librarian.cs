using System;

namespace classes_challenge {
    class Librarian {
    public int id {get; set;}
    public string firstName {get; set;}
    public string lastName {get; set;}
    public void checkOutBook(Book book, Library library, Patron patron){
        if(library.currentInventory.Contains(book)){
            library.currentInventory.Remove(book);
            patron.checkedOutBooks.Add(book);
            book.dueDate = DateTime.Now.AddDays(14);
            Console.WriteLine($"{patron.firstName} just checked out {book.title} from {library.name} and it is due back on {book.dueDate}");
        } else {
            Console.WriteLine($"The {library.name} does not currently have the book {book.title} in stock. Please check back later!");
        }
    }

    public void returnBook(Book book, Library library, Patron patron){
        if(patron.checkedOutBooks.Contains(book)){
            if(DateTime.Compare(DateTime.Now, book.dueDate) > 0){
             patron.overdueFees += .50;
             Console.WriteLine($"{patron.firstName} just returned {book.title} to the {library.name} with ${patron.overdueFees} in overdue fees.");
        } else {
            Console.WriteLine($"{patron.firstName} just returned {book.title} to the {library.name} with no overdue fees.");
        }
        patron.checkedOutBooks.Remove(book);
        library.currentInventory.Add(book);
        } else {
            Console.WriteLine($"{patron.firstName} did not check out this book!");
        }


    }
    }

}
