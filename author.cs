using System;
using System.Collections.Generic;

class Author : Person
{
  private List<Book> books = new List<Book>(); 

  public Author() : base()
  {
    Console.WriteLine("Author constructor");
  }

  public Author(string firstname, string lastname, string email) : base ()
  {
    Console.WriteLine("Author constructor with parameters");
    FirstName = firstname;
    LastName = lastname;
    Email = email;
  }

  public void DisplayInfo()
  {
    Console.WriteLine(FirstName + "\n" + LastName + "\n" + Email);
  }

  public void DisplayBooks()
  {
    foreach(Book b in books)
    {
      b.Display();
    }
  }

  public void AddBook(Book book)
  {
    books.Add(book);
  }

  public void RemoveBook(string isbn)
  {
    Book rbook = books.Find(b => b.ISBN == isbn);
    books.Remove(rbook);
  }

}