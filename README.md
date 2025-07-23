# docker-dotnet-framework-sample

A .NET Framework 4.8.1 MVC web application example converted from the [.NET 8 sample](../docker-dotnet-sample/) for Docker's .NET Language Guide.

This version includes Entity Framework 6 integration with a SQL Server database.

## Key Differences from .NET 8 Version

- **Framework**: Targets .NET Framework 4.8.1 instead of .NET 8
- **Project Structure**: Uses traditional MSBuild project format instead of SDK-style
- **Architecture**: Uses ASP.NET MVC instead of Razor Pages
- **Configuration**: Uses Web.config instead of appsettings.json
- **Database**: Uses Entity Framework 6 instead of EF Core
- **Database Provider**: Uses SQL Server/LocalDB instead of PostgreSQL
- **Docker**: Requires Windows containers instead of Linux containers

## Features

- Displays student information from Entity Framework database
- Uses Code First approach with automatic database initialization
- Includes sample data seeding

## Requirements

- Windows containers support in Docker
- .NET Framework 4.8.1 runtime (for local development)
- SQL Server (provided via Docker Compose)

## Docker Usage

This application requires Windows containers to run since .NET Framework only runs on Windows.

### Build and run with database:
```bash
docker-compose up
```

This will start both the web application and a SQL Server container.

### Build the image only:
```bash
docker build -t dotnet-framework-sample .
```

### Run the container only:
```bash
docker run -p 8080:80 dotnet-framework-sample
```

## Project Structure

- `src/` - Source code
  - `Controllers/` - MVC Controllers (includes database integration)
  - `Models/` - Data models (Student entity)
  - `Data/` - Entity Framework context and configuration
  - `Views/` - Razor Views
  - `wwwroot/` - Static files (CSS, JS, etc.)
  - `App_Start/` - Application startup configuration
  - `Global.asax` - Application lifecycle events
  - `Web.config` - Application and EF configuration
  - `packages.config` - NuGet package references

## Database

The application uses Entity Framework 6 with SQL Server. The database is automatically created and seeded with sample data when the application starts.

### Sample Data
- Student ID 1: Carson Alexander
- Student ID 2: Meredith Alonso  
- Student ID 3: Arturo Anand

## Branches

- `master` - Basic .NET Framework MVC application
- `add-db` - Includes Entity Framework 6 database integration

## Notes

- This application cannot be built or run on macOS/Linux without Windows containers
- The Docker image uses Windows Server Core base image
- Package dependencies are managed through packages.config rather than PackageReference
- Uses LocalDB for development, SQL Server container for Docker deployment