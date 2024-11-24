using MovieStore.Models.DTO;

namespace MovieStore.DL.Interfaces
{
    public interface IMovieRepository
    {
        List<Movie> GetAll();
        void Add(Movie movie);
        Movie UpdateMovie(int id, Movie movie);
        void DeleteMovie(int id);
        Movie GetById(int id);
    }
}
