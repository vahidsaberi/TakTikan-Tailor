#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/TakTikan.Tailor.Web.Public/TakTikan.Tailor.Web.Public.csproj", "src/TakTikan.Tailor.Web.Public/"]
COPY ["src/TakTikan.Tailor.Web.Core/TakTikan.Tailor.Web.Core.csproj", "src/TakTikan.Tailor.Web.Core/"]
COPY ["src/TakTikan.Tailor.Application/TakTikan.Tailor.Application.csproj", "src/TakTikan.Tailor.Application/"]
COPY ["src/TakTikan.Tailor.Application.Shared/TakTikan.Tailor.Application.Shared.csproj", "src/TakTikan.Tailor.Application.Shared/"]
COPY ["src/TakTikan.Tailor.Core.Shared/TakTikan.Tailor.Core.Shared.csproj", "src/TakTikan.Tailor.Core.Shared/"]
COPY ["src/TakTikan.Tailor.Core/TakTikan.Tailor.Core.csproj", "src/TakTikan.Tailor.Core/"]
COPY ["src/TakTikan.Tailor.EntityFrameworkCore/TakTikan.Tailor.EntityFrameworkCore.csproj", "src/TakTikan.Tailor.EntityFrameworkCore/"]
COPY ["src/TakTikan.Tailor.GraphQL/TakTikan.Tailor.GraphQL.csproj", "src/TakTikan.Tailor.GraphQL/"]
RUN dotnet restore "src/TakTikan.Tailor.Web.Public/TakTikan.Tailor.Web.Public.csproj"
COPY . .
WORKDIR "/src/src/TakTikan.Tailor.Web.Public"
RUN dotnet build "TakTikan.Tailor.Web.Public.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TakTikan.Tailor.Web.Public.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TakTikan.Tailor.Web.Public.dll"]
