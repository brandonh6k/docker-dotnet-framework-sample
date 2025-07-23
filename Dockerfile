# Use the official .NET Framework runtime image
FROM mcr.microsoft.com/dotnet/framework/aspnet:4.8.1-windowsservercore-ltsc2022

# Set the working directory
WORKDIR /inetpub/wwwroot

# Copy the application files
COPY src/ .

# Expose port 80
EXPOSE 80