using Microsoft.AspNetCore.Mvc;
using MovieCatalogAPI.Models;

namespace MovieCatalogAPI.Controllers
{
    [Route("api/movies")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
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
        public ActionResult<IEnumerable<Movie>> GetMovies()
        {
            return Ok(movies);
        }

        [HttpGet("{id}")]
        public ActionResult<Movie> GetMovie(int id)
        {
            var movie = movies.FirstOrDefault(m => m.Id == id);

            if (movie == null)
            {
                return NotFound("Movie not found");
            }

            return Ok(movie);
        }

        [HttpPost]
        public ActionResult<Movie> CreateMovie(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            movie.Id = movies.Max(m => m.Id) + 1;

            movies.Add(movie);

            return CreatedAtAction(nameof(GetMovie),
                new { id = movie.Id }, movie);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateMovie(int id, Movie updatedMovie)
        {
            var movie = movies.FirstOrDefault(m => m.Id == id);

            if (movie == null)
            {
                return NotFound("Movie not found");
            }

            movie.Title = updatedMovie.Title;
            movie.ReleaseYear = updatedMovie.ReleaseYear;
            movie.DirectorId = updatedMovie.DirectorId;

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteMovie(int id)
        {
            var movie = movies.FirstOrDefault(m => m.Id == id);

            if (movie == null)
            {
                return NotFound("Movie not found");
            }

            movies.Remove(movie);

            return NoContent();
        }
    }
}