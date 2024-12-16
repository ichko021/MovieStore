using MovieStore.DL.Interfaces;
using MovieStore.DL.StaticData;
using MovieStore.Models.DTO;

namespace MovieStore.DL.Repositories
{
//    public class MoviesStaticDataRepository : IMovieRepository
//    {
//        public List<Movie> GetAll()
//        {
//            return StaticDB.Movies;
//        }

//        public void Add(Movie movie)
//        {
//            StaticDB.Movies.Add(movie);
//        }

//        public Movie? UpdateMovie(int id, Movie movie)
//        {
//            if (id <= 0 || id > StaticDB.Movies.Count) return null;
//            StaticDB.Movies[id - 1] = movie;
//            return StaticDB.Movies[id - 1];
//        }

//        public void DeleteMovie(int id)
//        {
//            for (int i = id - 1; i < StaticDB.Movies.Count; i++)
//            {
//                StaticDB.Movies[i].Id -= 1;
//            }

//            StaticDB.Movies.RemoveAt(id - 1);
//        }
        
//        public Movie? GetById(int id)
//        {
//            if (id <= 0 || id > StaticDB.Movies.Count) return null;
//            return StaticDB.Movies[id-1];
//        }
//    }
}