#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/TakTikan.Tailor.Migrator/TakTikan.Tailor.Migrator.csproj", "src/TakTikan.Tailor.Migrator/"]
COPY ["src/TakTikan.Tailor.EntityFrameworkCore/TakTikan.Tailor.EntityFrameworkCore.csproj", "src/TakTikan.Tailor.EntityFrameworkCore/"]
COPY ["src/TakTikan.Tailor.Core/TakTikan.Tailor.Core.csproj", "src/TakTikan.Tailor.Core/"]
COPY ["src/TakTikan.Tailor.Core.Shared/TakTikan.Tailor.Core.Shared.csproj", "src/TakTikan.Tailor.Core.Shared/"]
RUN dotnet restore "src/TakTikan.Tailor.Migrator/TakTikan.Tailor.Migrator.csproj"
COPY . .
WORKDIR "/src/src/TakTikan.Tailor.Migrator"
RUN dotnet build "TakTikan.Tailor.Migrator.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TakTikan.Tailor.Migrator.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TakTikan.Tailor.Migrator.dll"]
