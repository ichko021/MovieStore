using MovieStore.Models.DTO;
using Mapster;
using MovieStore.Models.Requests;

namespace MovieStore.MapConfig
{
    public class MapsterConfiguration
    {
        public static void Configure()
        {
            TypeAdapterConfig<AddMovieRequest, Movie>.NewConfig();
        }
    }
}
