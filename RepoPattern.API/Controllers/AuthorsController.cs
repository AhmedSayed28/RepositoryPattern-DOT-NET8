using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepoPattern.Core.Models;
using RepoPattern.Core.Repositories;

namespace RepoPattern.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IBaseRepository<Author> _baseRepository;

        public AuthorsController(Core.Repositories.IBaseRepository<Author> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetAuthorById(int id) 
        {
            var author = _baseRepository.GetById(id);
            if (author == null)
                return NotFound();
            return Ok(author);
        }
    }
}
