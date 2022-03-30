#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 3000

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["purpleCow2.csproj", "."]
RUN dotnet restore "./purpleCow2.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "purpleCow2.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "purpleCow2.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "purpleCow2.dll"]
