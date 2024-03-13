using crud1.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//add database context to programe
builder.Services.AddCors();
builder.Services.AddDbContext<DonationDBContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("MyData")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(options=>options
   .WithOrigins("http://localhost:3000/")
   .AllowAnyHeader()
   .AllowAnyMethod()
   .AllowCredentials()
);

app.UseAuthorization();

app.MapControllers();

app.Run();
