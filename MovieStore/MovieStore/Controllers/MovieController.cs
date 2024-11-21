using Microsoft.AspNetCore.Mvc;
using MovieStore.BL.Interfaces;
using MovieStore.Models.DTO;
using System;

namespace MovieStore.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MovieController : ControllerBase
    {

        private readonly IMoviesService _moviesService;

        public MovieController(IMoviesService moviesService)
        {
            _moviesService = moviesService;
        }

        [HttpGet("allMovies")]
        public List<Movie> Get()
        { 
            return _moviesService.GetAll();
        }

        [HttpPost("addMovie")]
        public void Add([FromBody] Movie movie)
        {

            var requestBody = movie;
            _moviesService.AddMovie(requestBody);

        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _moviesService.DeleteMovie(id);
        }

        [HttpPut("{id}")]
        public ActionResult<Movie> Update(int id, Movie movie)
        {

            if ((id - 1) < 0 || id > _moviesService.GetAll().Count)
            {
                return NotFound($"No movie found at index {id}.");
            }
            else
            {
                return _moviesService.UpdateMovie(id, movie);
            }
            
        }

        [HttpGet("{id}")]
        public ActionResult<Movie> GetById(int id)
        {
            if ((id - 1) < 0 || id > _moviesService.GetAll().Count)
            {
                return NotFound($"No movie found at index {id}.");
            } 
            else
            {
                return _moviesService.GetMovieById(id);
            }
            
        }
    }
}
