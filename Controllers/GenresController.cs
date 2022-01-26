using MoviesAPI.Services;
using MoviesAPI.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MoviesAPI.Controllers
{
    /*[Route("api/[controller]")]*/
    [Route("api/genres")]
    public class GenresController
    {
        private readonly IRepository repository;
        public GenresController(IRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]//api/genres
        [HttpGet("list")]//api/genres/list
        [HttpGet("/allgenres")]//allgenres
        /*Both the end points will give the same result*/
        public ActionResult<List<Genre>> Get()
        {
            return repository.GetAllGenres();
        }

        [HttpGet("{Id}")]//api/genres/{Id} 
        public ActionResult<Genre> Get(int Id)
        {
            var genre = repository.GetGenreById(Id);
            if(genre == null)
            {
                return NotFound();
            }
            return genre;
        }

        [HttpPost]
        public ActionResult Post()
        {
            return NoContent();

        }
        [HttpPut]
        public ActionResult Put()
        {
            return NoContent();

        }
        [HttpDelete]
        public ActionResult Delete()
        {
            return NoContent();
        }
    }
}
