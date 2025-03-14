using Bibliotekarz.Client.Model;
using Bibliotekarz.Data.Context;
using Bibliotekarz.Data.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Book = Bibliotekarz.Data.Model.Book;

namespace Bibliotekarz.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class BooksController : ControllerBase
{
    private readonly AppDbContext dbContext;

    public BooksController(AppDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll([FromQuery] string? searchText)
    {
        var query = dbContext.Books.AsQueryable();

        if (!string.IsNullOrWhiteSpace(searchText))
        {
            query = query.Where(book => book.Title.ToLower().Contains(searchText.ToLower())
                                      || book.Author.ToLower().Contains(searchText));
        }

        query = query.OrderBy(book => book.Author).ThenBy(book => book.Title);



        return Ok(await query.ToListAsync());
        return NotFound();
        return Unauthorized();
        return StatusCode(StatusCodes.Status418ImATeapot);
    }

    [HttpGet("[action]/{id}")] //localhost/Books/GetBook/123
    public async Task<IActionResult> GetBook(int id)
    {
        Book? book = await dbContext.Books.FirstOrDefaultAsync(book => book.Id == id);

        if (book == null)
        {
            return NotFound();
        }
        else
        {
            return Ok(book);
        }
    }

    [HttpPost]
    public async Task<IActionResult> Add(Book book)
    {
        dbContext.Books.Add(book);
        await dbContext.SaveChangesAsync();

        return Created($"Books/GetBook/{book.Id}", book);
    }

}
