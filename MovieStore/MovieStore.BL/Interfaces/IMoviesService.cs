using MovieStore.Models.DTO;

namespace MovieStore.BL.Interfaces
{
    public interface IMoviesService
    {
        List<Movie> GetAll();
        void AddMovie(Movie movie);
        Movie UpdateMovie(int id, Movie movie);
        void DeleteMovie(int id);
        Movie GetMovieById(int id);
    }
}
