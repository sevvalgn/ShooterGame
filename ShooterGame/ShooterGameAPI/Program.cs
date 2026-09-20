
using Microsoft.AspNetCore.Connections;
using Microsoft.EntityFrameworkCore;
using ShooterGameAPI.Data;

namespace ShooterGameAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<GameDbContext>(options => options.UseMySql(builder.Configuration.GetConnectionString(
                "LeaderboardConnection"), ServerVersion.AutoDetect(builder.Configuration.GetConnectionString(
                "LeaderboardConnection"))));

            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
