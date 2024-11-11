# C# backend using ASP.NET
This is a simple backend using ASP.NET.

## Installation
```sh
sudo dnf install dotnet-sdk-8.0
```

## Usage 
Copy and paste this command to your terminal:
```sh
ASPNETCORE_URLS=http://localhost:5000 dotnet run
```
This will ensure you are on the port that is specified in the rocketgame documentation. 

Before you test the API, you must make sure you have a database and a frontend URL for the rocket game.

## Environment Variables
Create a `.env` file in the root of your project and add the following:

```properties
DefaultConnection=Host=your_host;Database=your_database;Username=your_username;Password=your_password;sslmode=require
WebsiteUrl=http://localhost:your_port
```
## Database troubleshooting
If you are not using the database I made, you should still be able to make one using the schema by running 
```bash 
dotnet ef migrations add InitialCreate
```

## Testing with Postman
- Select POST on request setting, then place this in the URL http://localhost:5146/api/Leaderboard
- After this go to body. Select RAW and JSON as the type. 
Paste this into body (Change the fields accordingly)

{
  "PlayerId": 1,
  "Username": "Player1",
  "PlayerScore": 100
}

Press send. If it gives you errors check the port and/or the database config in .env.

## DotNet Specs for this project
   [net8.0]: 
   Top-level Package                            Requested   Resolved
   > DotNetEnv                                  3.1.1       3.1.1   
   > Microsoft.AspNetCore.OpenApi               8.0.10      8.0.10  
   > Npgsql.EntityFrameworkCore.PostgreSQL      8.0.10      8.0.10  
   > Swashbuckle.AspNetCore                     6.6.2       6.6.2   

## Features
- Utilizing PostgreSQL 
- Website URL in .env
- SQL database specified in .env
- SQL Schema to create columns for player_id, player_name, and player_score.
- SQL Schema includes utilizing indexing to speed up search process. 
- GET and POST methods for getting player_id, player_name, and player_score.
- Used postman to confirm get and post methods work.