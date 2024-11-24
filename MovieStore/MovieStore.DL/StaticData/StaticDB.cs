using MovieStore.Models.DTO;

namespace MovieStore.DL.StaticData
{
    internal static class StaticDB
    {

        public static List<Movie> Movies { get; set; } = new List<Movie>() { 
            new Movie()
            {
                Id = 1,
                Title = "Test1",
                Year = 2016,
            },
            new Movie()
            {
                Id = 2,
                Title = "Test2",
                Year = 2017,
            },
            new Movie()
            {
                Id = 3,
                Title = "Test3",
                Year = 2018,
            }
        }; 
    }
}
