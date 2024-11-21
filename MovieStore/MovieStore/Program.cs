using MovieStore.BL.Interfaces;
using MovieStore.BL.Services;
using MovieStore.DL.Interfaces;
using MovieStore.DL.Repositories;

namespace MovieStore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddSingleton<IMoviesService, MoviesService>();
            builder.Services.AddSingleton<IMovieRepository, MoviesStaticDataRepository>();

            builder.Services.AddControllers();

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
