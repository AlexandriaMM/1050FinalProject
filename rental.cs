using System;

class Rental {
  public Book RentalBook { get; set; }
  public DateTime DateRented { get; set; }
  public DateTime DateDue { get; set; }

  public Rental(Book rbook, DateTime rdate, DateTime ddate)
  {
    RentalBook = rbook;
    DateRented = rdate;
    DateDue = ddate;
  }
}