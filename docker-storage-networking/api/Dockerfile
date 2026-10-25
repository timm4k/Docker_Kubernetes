FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY StorageNetworking.Api.csproj .
RUN dotnet restore
COPY Program.cs .
COPY Controllers/ Controllers/
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /publish .
ENV ASPNETCORE_URLS=http://127.0.0.1:5000 \
    ASPNETCORE_HTTP_PORTS=""
USER app
EXPOSE 5000
ENTRYPOINT ["dotnet", "StorageNetworking.Api.dll"]
