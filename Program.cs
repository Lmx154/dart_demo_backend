using Microsoft.EntityFrameworkCore;
using MyBackend.Data;
using DotNetEnv;

var builder = WebApplication.CreateBuilder(args);

// Load environment variables from .env file
Env.Load();

// Configure the PostgreSQL database context
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(Environment.GetEnvironmentVariable("DefaultConnection")));

builder.Services.AddControllers();

// Add a configuration variable for the website URL
var websiteUrl = Environment.GetEnvironmentVariable("WebsiteUrl");

var app = builder.Build();

app.MapControllers();

app.Run();
