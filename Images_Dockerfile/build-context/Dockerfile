FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY MyApp.Api/MyApp.Api.csproj MyApp.Api/
RUN dotnet restore MyApp.Api/MyApp.Api.csproj
COPY . .
RUN test ! -e MyApp.Tests && \
    dotnet publish MyApp.Api/MyApp.Api.csproj -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /publish .
USER app
EXPOSE 8080
CMD ["dotnet", "MyApp.Api.dll"]
