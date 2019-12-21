using System;
using System.Collections.Generic;

namespace HomeLibrary.API.Model
{
  public class Book
  {
    public int Id { get; set; }
    public string Title { get; set; }
    public List<string> Authors { get; set; }
    public string Publisher { get; set; }
    public DateTime PublishedDate { get; set; }
    public string Description { get; set; }
    public int PageCount { get; set; }
    public string MainCategory { get; set; }
    public List<string> Categories { get; set; }
    public string Language { get; set; }
  }
}
