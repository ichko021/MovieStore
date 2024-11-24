using MapsterMapper;
using Microsoft.AspNetCore.Mvc;
using MovieStore.BL.Interfaces;
using MovieStore.BL.Services;
using MovieStore.Models.DTO;
using MovieStore.Models.Requests;

namespace MovieStore.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MovieController : ControllerBase
    {

        private readonly IMoviesService _moviesService;
        private readonly IMapper _mapper;

        public MovieController(IMoviesService moviesService, IMapper mapper)
        {
            _moviesService = moviesService;
            _mapper = mapper;
        }

        [HttpGet("GetAll")]
        public List<Movie> Get()
        { 
            return _moviesService.GetAll();
        }

        [HttpPost("Add")]
        public void Add([FromBody] AddMovieRequest movie)
        {

            var movieDto = _mapper.Map<Movie>(movie);
            movieDto.Id = _moviesService.GetAll().Count + 1;

            _moviesService.Add(movieDto);

        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpDelete("Delete")]
        public IActionResult Delete(int id)
        {
            if ((id - 1) < 0 || id > _moviesService.GetAll().Count)
            {
                return NotFound($"No movie found at index {id}.");
            }
            else
            {
                _moviesService.DeleteMovie(id);
                return Ok();
            }
            
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpPut("UpdateById")]
        public IActionResult Update(int id, [FromBody] AddMovieRequest movie)
        {

            if ((id - 1) < 0 || id > _moviesService.GetAll().Count)
            {
                return BadRequest($"Wrond ID: {id}");
            }

            var movieDto = _mapper.Map<Movie>(movie);

            var result = _moviesService.UpdateMovie(id, movieDto);

            if (result == null)
            {
                return NotFound($"Movie with ID:{id} not found");
            }

            else
            {
                return Ok();
            }

        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            if (id <= 0)
            {
                return BadRequest($"Wrond ID: {id}");
            }

            var result = _moviesService.GetById(id);

            if (result == null)
            {
                return NotFound($"Movie with ID:{id} not found");
            }

            return Ok(result);

        }
    }
}
