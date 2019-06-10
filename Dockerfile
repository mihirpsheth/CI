FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["WebApplication8.csproj", "./"]
RUN dotnet restore "/WebApplication8.csproj"
COPY . .
WORKDIR "/src/"
RUN dotnet build "WebApplication8.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "WebApplication8.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "WebApplication8.dll"]
