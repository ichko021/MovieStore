using MovieStore.DL.Interfaces;
using MovieStore.DL.StaticData;
using MovieStore.Models.DTO;

namespace MovieStore.DL.Repositories
{
    public class MoviesStaticDataRepository : IMovieRepository
    {
        public List<Movie> GetAll()
        {
            return StaticDB.Movies;
        }

        public void AddMovie(Movie movie)
        {
            StaticDB.Movies.Add(movie);
        }

        public Movie UpdateMovie(int id, Movie movie)
        {
            StaticDB.Movies[id - 1] = movie;
            return StaticDB.Movies[id - 1];
        }

        public void DeleteMovie(int id)
        {
            StaticDB.Movies.RemoveAt(id - 1);
        }

        public Movie GetMovieById(int id)
        {
            return StaticDB.Movies[id - 1];
        }
    }
}
