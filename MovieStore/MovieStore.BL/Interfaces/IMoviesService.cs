using MovieStore.Models.DTO;

namespace MovieStore.BL.Interfaces
{
    public interface IMoviesService
    {
        List<Movie> GetAll();
        void Add(Movie movie);
        Movie UpdateMovie(int id, Movie movie);
        void DeleteMovie(int id);
        Movie GetById(int id);
    }
}
