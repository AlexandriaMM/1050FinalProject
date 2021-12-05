using System;

class Program 
{
  public static void Main (string[] args) {
    //Console.WriteLine ("Hello World");
    Author a1 = new Author("John", "Smith", "JSmith@email.com");
    Author a2 = new Author("Laura", "Tomson", "LTomson@email.com");
    
    a1.DisplayInfo();
    a2.DisplayInfo();

    Book b1 = new Book("123abc", "Test Book 1", a1);
    Book b2 = new Book("223abc", "Test Book 2", a2);
    Book b3 = new Book("323abc", "Test Book 3", a1);
    Book b4 = new Book("333abc", "Test Book 4", a2, DateTime.Now, "publishing company 1");
    Book b5 = new Book("123bbc", "Test Book 5", a1, DateTime.Now, "publishing company 2");
    Book b6 = new Book("123bcc", "Test Book 6", a2, DateTime.Now, "publishing company 3");

    a1.AddBook(b1);
    a1.AddBook(b3);
    a1.AddBook(b5);

    a1.DisplayBooks();
    
    a2.AddBook(b2);
    a2.AddBook(b4);
    a2.AddBook(b6);

    a2.DisplayBooks();

    a1.RemoveBook("123abc");

    a1.DisplayBooks();

    Patron p1 = new Patron("Joan", "Miller", "132asdf");
    Patron p2 = new Patron("Patrick", "McNally", "sd32f1");
    Patron p3 = new Patron("Samantha", "Walker", "xccvb12");
    Patron p4 = new Patron("Michael", "Johnson", "qewr234");
    Patron p5 = new Patron("Sally", "Candas", "rutyw4356");

    p1.AddToRentalCart(b1, DateTime.Now);

    p1.RemoveFromRentalCart(b3);

    p1.Display();
  }
}