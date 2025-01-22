using MovieStore.Models.Responses;
using MovieStore.Models.Views;


namespace MovieStore.BL.Interfaces
{
    public interface IMovieBlService
    {
        List<MovieView> GetAll();
        List<MovieView> GetDetailedMovies();
    }
}
