FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Tarea_9_Docker.csproj", "."]
RUN dotnet restore "./Tarea_9_Docker.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "Tarea_9_Docker.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Tarea_9_Docker.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Tarea_9_Docker.dll"]