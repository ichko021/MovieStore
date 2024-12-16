using MovieStore.Models.Responses;


namespace MovieStore.BL.Interfaces
{
    public interface IBusinessService
    {
        List<MovieFullDetailsResponse> GetAllMovies();
    }
}
