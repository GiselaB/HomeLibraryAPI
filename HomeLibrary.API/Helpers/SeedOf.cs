using System;
using System.Collections.Generic;
using HomeLibrary.API.Model;

namespace HomeLibrary.API.Helpers
{
  public static class SeedOf
  {
    public static List<Book> Books()
    {
      var books = new List<Book>
      {
        new Book()
        {
          Id = 1,
          Title = "The Google story",
          Authors = new List<string>()
          {
            "David A. Vise",
            "Mark Malseed"
          },
          Publisher = "Random House Digital, Inc.",
          PublishedDate = new DateTime(2005, 11, 15),
          Description = "Here is the story behind one of the most remarkable Internet successes of our time.Based on scrupulous research and extraordinary access to Google, ...",
          MainCategory = "Business & Economics / Entrepreneurship"
        },
        new Book()
        {
          Id = 2,
          Title = "The story",
          Authors = new List<string>()
          {
            "David A.",
            "Malseed"
          },
          Publisher = "Random House, Inc.",
          PublishedDate = new DateTime(2005, 11, 15),
          Description = "Here is the story behind one of the most remarkable Internet successes of our time.Based on scrupulous research and extraordinary access to Google, ...",
          MainCategory = "Business"
        }
      };
      return books;
    }
  }
}
