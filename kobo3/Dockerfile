#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["kobo3/kobo3.csproj", "kobo3/"]
RUN dotnet restore "kobo3/kobo3.csproj"
COPY . .
WORKDIR "/src/kobo3"
RUN dotnet build "kobo3.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "kobo3.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "kobo3.dll"]
