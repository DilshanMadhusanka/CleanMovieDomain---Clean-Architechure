using CleanMovie.Domain;
using CleanMovieApplication;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CleanMovie.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {

        private readonly IMovieServices services;

        public MoviesController(IMovieServices services)
        {
             Services = services;
        }

       public IMovieServices Services { get; }

        [HttpGet]
        public ActionResult<List <Movie>> Get()
        {
            var moviesFromServices = Services.GetAllMovies();

            return Ok(moviesFromServices );
        }


       
    }
}
