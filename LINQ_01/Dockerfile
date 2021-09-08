FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["LINQ_01/LINQ_01.csproj", "LINQ_01/"]
RUN dotnet restore "LINQ_01/LINQ_01.csproj"
COPY . .
WORKDIR "/src/LINQ_01"
RUN dotnet build "LINQ_01.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LINQ_01.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LINQ_01.dll"]
