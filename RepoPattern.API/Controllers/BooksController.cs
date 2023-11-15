using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepoPattern.Core.Models;
using RepoPattern.Core.Repositories;

namespace RepoPattern.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBaseRepository<Book> _baseRepository;

        public BooksController(IBaseRepository<Book> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetBookById(int id) 
        {
            var book = _baseRepository.GetById(id);
            if (book == null)
                return NotFound();
            return Ok(book);
        }
    }
}
