using DnsClient.Internal;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MovieStore.DL.Interfaces;
using MovieStore.Models.DTO;
using MovieStore.Models.Configurations;

namespace MovieStore.DL.Repositories.MongoDb
{
    internal class MoviesMongoRepository : IMovieRepository
    {
        private readonly IMongoCollection<Movie> _moviesCollection;
        private readonly ILogger<MoviesMongoRepository> _logger;

        public MoviesMongoRepository(
            IOptionsMonitor<MongoDbConfiguration> mongoConfig,
            ILogger<MoviesMongoRepository> logger)
        {
            _logger = logger;

            var client =
                new MongoClient(mongoConfig.CurrentValue.ConnectionString);
            var database = client.GetDatabase(
                mongoConfig.CurrentValue.DatabaseName);
            _moviesCollection = database.GetCollection<Movie>("MoviesDb");
        }

        public void Add(Movie movie)
        {
            throw new NotImplementedException();
        }

        public void DeleteMovie(int id)
        {
            throw new NotImplementedException();
        }

        public List<Movie> GetAll()
        {
            return _moviesCollection.Find(m => true)
                .ToList();
        }

        public Movie? GetById(string id)
        {
            throw new NotImplementedException();
        }

        public Movie GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Movie UpdateMovie(int id, Movie movie)
        {
            throw new NotImplementedException();
        }
    }
}