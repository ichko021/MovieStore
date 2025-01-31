using MovieStore.BL.Interfaces;
using MovieStore.DL.Interfaces;
using MovieStore.Models.DTO;

namespace MovieStore.BL.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;
        private readonly IActorRepository _actorRepository;
        public MovieService(IMovieRepository movieRepository, IActorRepository actorRepository) 
        { 
            _movieRepository = movieRepository; 
            _actorRepository = actorRepository; 
        }

        public List<Movie> GetAll()
        {
            return _movieRepository.GetAll();
        }

        public void Add(Movie movie)
        {
            if (movie is null) return;

            foreach (var movieActor in movie.Actors)
            {
                var actor = _actorRepository.GetById(movieActor);

                if (actor is null)
                {
                    throw new Exception(
                        $"Actor with id {movieActor} does not exist");
                }
            }

            _movieRepository.Add(movie);
        }

        //public Movie UpdateMovie(int id, Movie movie)
        //{
        //    return _movieRepository.UpdateMovie(id, movie);
        //}

        //public void DeleteMovie(int id)
        //{
        //    _movieRepository.DeleteMovie(id);
        //}

        public Movie? GetById(string id)
        {
            if (string.IsNullOrEmpty(id)) return null;

            return _movieRepository.GetById(id);
        }
    }
}
