FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY SystemInfo.csproj .
RUN dotnet restore
COPY Program.cs .
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/runtime:8.0
ENV APP_NAME=SystemInfo
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "SystemInfo.dll"]
