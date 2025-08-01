
using Business.Implementations;
using Business.Interfases;
using Data.Implements;
using Data.Interfases;
using Entity.Conetxt;
using Entity.Dtos;
using Entity.Models;
using Microsoft.EntityFrameworkCore;
using Utilities.Mapper;
using Web.Hubs;

namespace Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddSignalR();

            var connection = builder.Configuration.GetConnectionString("DefaultConnection");


            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connection)
            );


            builder.Services.AddCors(options =>
            {
                options.AddDefaultPolicy(policy =>
                    policy.WithOrigins("http://localhost:4200")
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials()
                    );
            });

            Mapping.MappingConfiguration();


            builder.Services.AddScoped<IBaseData<Player>, PlayerRepository>();
            builder.Services.AddScoped<IBaseBusiness<Player, PlayerDto>, PlayerBusiness>();


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseCors();


            app.UseAuthorization();

            app.UseAuthentication();


            app.MapControllers();
            app.MapHub<Game>("/gamehub");


            app.Run();
        }
    }
}
