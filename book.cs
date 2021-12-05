using System; 

class Book
{
  //Auto-implemented properties
  public string ISBN { get; set; }
  public string Title { get; set; }
  public Author AuthorInfo { get; set; }
  public DateTime PublishedOn { get; set; }
  public string PublishedBy { get; set; }

  public Book(string lisbn, string ltitle, Author lauthorInfo)
  {
    ISBN = lisbn;
    Title = ltitle;
    AuthorInfo = lauthorInfo;
    PublishedOn = DateTime.Now;
    PublishedBy = "unknown";
    Console.WriteLine("Book constructor");
  }

  public Book(string lisbn, string ltitle, Author lauthorInfo, DateTime lPublishedOn, string lpublishedBy)
  {
    ISBN = lisbn;
    Title = ltitle;
    AuthorInfo = lauthorInfo;
    PublishedOn = lPublishedOn;
    PublishedBy = lpublishedBy;
    Console.WriteLine("Book constructor");
  }
  
  public void Display()
  {
    Console.WriteLine("Book " + Title + " was written by " + AuthorInfo.FirstName + " " + AuthorInfo.LastName + " and published on " + PublishedOn);
  }
  
}

