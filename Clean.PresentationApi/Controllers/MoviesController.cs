using Clean.Application;
using Clean.Application.Commands;
using Clean.Application.Queries;
using Clean.Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Clean.PresentationApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MoviesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/<MoviesController>
        [HttpGet]
        public ActionResult<List<Movie>> Get()
        {
            var allMovies = _mediator.Send(new GetAllMoviesQuery()); ;
            return Ok(allMovies);
        }

        [HttpPost]
        public ActionResult<Movie> PostMovie(Movie movie)
        {
            var Movie = new CreateMovieCommand() { newMovie = movie };
            var result = _mediator.Send(Movie);
            return Ok(result);
        }
    }
}
