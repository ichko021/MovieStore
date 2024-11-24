using Microsoft.Extensions.DependencyInjection;
using MovieStore.DL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieStore.BL.Interfaces;
using MovieStore.BL.Services;

namespace MovieStore.BL
{
    public static class DependenciesInjection
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            return services.AddSingleton<IMoviesService, MoviesService>();
        }
    }
}
