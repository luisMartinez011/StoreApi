using StoreAPI.Data;
using Microsoft.EntityFrameworkCore;
using StoreAPI.Data.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var Configuration = builder.Configuration;
// !!Revisar si inyectamos un archivo .sql cada vez que se inicie o usamos una base de datos en la nube
builder.Services.AddDbContext<AppDbContext>(options =>
        options.UseNpgsql(Configuration.GetConnectionString("LocalDB"),
        x => x.MigrationsHistoryTable("_EfMigrations", Configuration.GetSection("Schema").GetSection("User").Value)));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
