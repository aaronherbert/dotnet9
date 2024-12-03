
using Microsoft.Extensions.Options;
using Scalar.AspNetCore;

namespace WhatsNew.Api9
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddOpenApi();
            // Add services to the container.

            builder.Services.AddControllers();
            // https://localhost:7189/openapi/v1.json
            builder.Services.AddOpenApi();

            var app = builder.Build();


            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
                app.MapScalarApiReference(); //https://localhost:7189/scalar/v1

            }

            //  app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
