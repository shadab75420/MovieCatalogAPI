using Microsoft.AspNetCore.Mvc;
using MovieCatalogAPI.Models;

namespace MovieCatalogAPI.Controllers
{
    [Route("api/directors")]
    [ApiController]
    public class DirectorsController : ControllerBase
    {
        private static List<Director> directors = new List<Director>
        {
            new Director
            {
                Id = 1,
                Name = "Christopher Nolan"
            },

            new Director
            {
                Id = 2,
                Name = "James Cameron"
            }
        };

        private static List<Movie> movies = new List<Movie>
        {
            new Movie
            {
                Id = 1,
                Title = "Inception",
                ReleaseYear = 2010,
                DirectorId = 1
            },

            new Movie
            {
                Id = 2,
                Title = "Interstellar",
                ReleaseYear = 2014,
                DirectorId = 1
            },

            new Movie
            {
                Id = 3,
                Title = "Titanic",
                ReleaseYear = 1997,
                DirectorId = 2
            }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Director>> GetDirectors()
        {
            return Ok(directors);
        }

        [HttpGet("{id}")]
        public ActionResult<Director> GetDirector(int id)
        {
            var director = directors.FirstOrDefault(d => d.Id == id);

            if (director == null)
            {
                return NotFound("Director not found");
            }

            return Ok(director);
        }

        [HttpPost]
        public ActionResult<Director> CreateDirector(Director director)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            director.Id = directors.Max(d => d.Id) + 1;

            directors.Add(director);

            return CreatedAtAction(nameof(GetDirector),
                new { id = director.Id }, director);
        }

        [HttpGet("{directorId}/movies")]
        public ActionResult<IEnumerable<Movie>> GetMoviesByDirector(int directorId)
        {
            var director = directors.FirstOrDefault(d => d.Id == directorId);

            if (director == null)
            {
                return NotFound("Director not found");
            }

            var directorMovies = movies
                .Where(m => m.DirectorId == directorId)
                .ToList();

            return Ok(directorMovies);
        }
    }
}