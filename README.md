# C# backend using ASP.NET
This is a simple backend using ASP.NET.

## Installation
```sudo dnf install dotnet-sdk-8.0```

## Usage
```dotnet run```

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
- 