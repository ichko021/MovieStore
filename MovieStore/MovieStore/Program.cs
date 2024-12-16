using FluentValidation;
using FluentValidation.AspNetCore;
using Mapster;
using MovieStore.DL;
using MovieStore.Models.Configurations;
using MovieStore.Validators;
using MovieStore.BL;
using MovieStore.BL.Interfaces;
using MovieStore.DL;
using MovieStore.Models.Configurations;
using MovieStore.Validators;

namespace MovieStoreC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //Add configurations
            builder.Services.Configure<MongoDbConfiguration>(
                builder.Configuration
                    .GetSection(nameof(MongoDbConfiguration)));

            // Add services to the container.
            builder.Services
                .RegisterRepositories()
                .RegisterServices();

            builder.Services.AddMapster();

            builder.Services.AddControllers();

            builder.Services
                .AddValidatorsFromAssemblyContaining<TestValidator>();
            builder.Services.AddFluentValidationAutoValidation();

            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }


            // Configure the HTTP request pipeline.

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}