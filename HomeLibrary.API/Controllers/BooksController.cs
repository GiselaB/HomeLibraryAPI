using System.Collections.Generic;
using System.Linq;
using HomeLibrary.API.Helpers;
using HomeLibrary.API.Model;
using Microsoft.AspNetCore.Mvc;

namespace HomeLibrary.API.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class BooksController : ControllerBase
  {
    private static List<Book> _books = SeedOf.Books();
    private static int _counter = 2;

    //get
    [HttpGet]
    public List<Book> GetList() => _books;

    [HttpGet("{id}")]
    public Book GetBook(int id) => _books.FirstOrDefault(x => x.Id == id);

    //post
    [HttpPost]
    public Book Include([FromBody] Book book)
    {
      book.Id = (_counter++);
      _books.Add(book);
      return _books.Last();
    }

    [HttpPut]
    public ActionResult<Book> Update([FromBody] Book book)
    {
      if (!_books.Any(x => x.Id == book.Id)) return BadRequest("Id inválido");

      var index = _books.IndexOf(_books.Find(x => x.Id == book.Id));
      _books[index] = book;

      return Ok(_books[index]);
    }
    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
      if (!_books.Any(x => x.Id == id)) return BadRequest("Id inválido");
      _books.Remove(_books.Find(x => x.Id == id));
      return Ok();
    }
  }
}
