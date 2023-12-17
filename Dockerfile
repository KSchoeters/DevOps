# Use the official ASP.NET Core runtime image as the base image
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS base
WORKDIR /app
EXPOSE 80

# Copy the published application to the /app directory in the container
COPY . .

# Define the command to run your application
ENTRYPOINT ["dotnet", "Vacation.dll"]
