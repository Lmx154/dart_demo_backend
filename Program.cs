using Microsoft.EntityFrameworkCore;
using MyBackend.Data;

var builder = WebApplication.CreateBuilder(args);

// Hardcode environment variables
var websiteUrl = "https://rocketcs.web.app";
var connectionString = "Host=ep-dark-violet-a5oxgnzd.us-east-2.aws.neon.tech;Database=neondb;Username=neondb_owner;Password=EL9axqWIU6rM;sslmode=require";

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add the connection string
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(connectionString));

// Add CORS policy
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        builder => builder.AllowAnyOrigin()
                          .AllowAnyMethod()
                          .AllowAnyHeader());
});

var app = builder.Build();

// Apply any pending migrations
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    dbContext.Database.Migrate();
}

// Enable CORS
app.UseCors("AllowAll");

// Enable Swagger middleware for both development and production
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "MyBackend API V1");
    c.RoutePrefix = string.Empty; // Set Swagger UI at the app's root
});

app.MapControllers();

app.Run();
