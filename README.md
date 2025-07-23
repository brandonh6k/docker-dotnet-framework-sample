# docker-dotnet-framework-sample

A .NET Framework 4.8.1 MVC web application example converted from the [.NET 8 sample](../docker-dotnet-sample/) for Docker's .NET Language Guide.

## Key Differences from .NET 8 Version

- **Framework**: Targets .NET Framework 4.8.1 instead of .NET 8
- **Project Structure**: Uses traditional MSBuild project format instead of SDK-style
- **Architecture**: Uses ASP.NET MVC instead of Razor Pages
- **Configuration**: Uses Web.config instead of appsettings.json
- **Docker**: Requires Windows containers instead of Linux containers

## Requirements

- Windows containers support in Docker
- .NET Framework 4.8.1 runtime (for local development)

## Docker Usage

This application requires Windows containers to run since .NET Framework only runs on Windows.

### Build the image:
```bash
docker build -t dotnet-framework-sample .
```

### Run the container:
```bash
docker run -p 8080:80 dotnet-framework-sample
```

Or use docker-compose:
```bash
docker-compose up
```

## Project Structure

- `src/` - Source code
  - `Controllers/` - MVC Controllers
  - `Views/` - Razor Views
  - `wwwroot/` - Static files (CSS, JS, etc.)
  - `App_Start/` - Application startup configuration
  - `Global.asax` - Application lifecycle events
  - `Web.config` - Application configuration
  - `packages.config` - NuGet package references

## Notes

- This application cannot be built or run on macOS/Linux without Windows containers
- The Docker image uses Windows Server Core base image
- Package dependencies are managed through packages.config rather than PackageReference