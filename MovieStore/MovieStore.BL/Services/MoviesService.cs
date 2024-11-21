using MovieStore.BL.Interfaces;
using MovieStore.DL.Interfaces;
using MovieStore.Models.DTO;

namespace MovieStore.BL.Services
{
    public class MoviesService : IMoviesService
    {
        private readonly IMovieRepository _movieRepository;

        public MoviesService(IMovieRepository movieRepository) { _movieRepository = movieRepository; }

        public List<Movie> GetAll()
        {
            return _movieRepository.GetAll();
        }

        public void AddMovie(Movie movie)
        {
            _movieRepository.AddMovie(movie);
        }

        public Movie UpdateMovie(int id, Movie movie)
        {
            return _movieRepository.UpdateMovie(id, movie);
        }

        public void DeleteMovie(int id)
        {
            _movieRepository.DeleteMovie(id);
        }

        public Movie GetMovieById(int id)
        {
            return _movieRepository.GetMovieById(id);
        }
    }
}
