
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Portfolio/Portfolio.csproj", "Portfolio/"]
RUN dotnet restore "./Portfolio/Portfolio.csproj"
COPY . .
WORKDIR "/src/Portfolio"
RUN dotnet build "./Portfolio.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Portfolio.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=true

#FROM base AS final
#WORKDIR /app
#COPY --from=publish /app/publish .
#ENTRYPOINT ["dotnet", "Portfolio.dll"]
#
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR	/app
EXPOSE 8080
COPY --from=publish /app/publish .
ENTRYPOINT ["./Portfolio"] 