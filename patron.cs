using System;
using System.Collections.Generic;

class Patron : Person
{
  public string LibraryId { get; set; }
  public DateTime StartDate { get; set; }
  public DateTime EndDate { get; set; }
  public bool IsAccountActive { get; set; }
  public List<Book> RentalCart = new List<Book>();
  public double FineAmountDue { get; set; }

  public Patron(string fname, string lname, string cid) : base ()
  {
    FirstName = fname;
    LastName = lname;
    LibraryId = cid;
    FineAmountDue = 0.00;
    StartDate = DateTime.Now;
    IsAccountActive = true;
    Console.WriteLine("Patron constructor");
  }

  public void Display()
  {
    Console.WriteLine("Patron Id = " + LibraryId + " Name = " + FirstName + " " + LastName);
  }

  public void AddToRentalCart(Book rentalObject, DateTime dueDate)
  {
    RentalCart.Add(rentalObject);
    Console.WriteLine("Added to rental cart " + rentalObject.Title + " for Patron" + FirstName + " " + LastName);
  }

  public void RemoveFromRentalCart(Book rObject)
  {
    RentalCart.Remove(rObject);
    Console.WriteLine("Removed from rental cart " + rObject.Title + " for Patron " + FirstName + " " + LastName);
  }

}