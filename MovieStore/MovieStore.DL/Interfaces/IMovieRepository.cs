using MovieStore.Models.DTO;

namespace MovieStore.DL.Interfaces
{
    public interface IMovieRepository
    {
        List<Movie> GetAll();
        void AddMovie(Movie movie);
        Movie UpdateMovie(int id, Movie movie);
        void DeleteMovie(int id);
        Movie GetMovieById(int id);
    }
}
