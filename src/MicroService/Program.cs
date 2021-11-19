using System.Text.Json.Serialization;

namespace MicroService
{
    public static class Program
    {
        const string LocalOrigins = "_localorigins";

        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddCors(options =>
            {
                options.AddPolicy(LocalOrigins,
                    builder =>
                    {
                        builder
                            .WithOrigins(
                                "https://localhost:3000",
                                "https://localhost:3001",
                                "https://localhost:3002",
                                "https://localhost:3003",
                                "https://localhost:3004",
                                "https://localhost:3005",
                                "https://localhost:3009",
                                "https://localhost:3100")
                            .AllowAnyHeader()
                            .AllowAnyMethod()
                            .AllowCredentials();
                    });
            });

            builder.Services.AddApplicationLayer();

            builder.Services.AddDomainLayer();

            builder.Services.AddInfrastructureLayer();

            builder.Services.AddControllers().AddJsonOptions(o => o.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull);
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseCors(LocalOrigins);
            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}



