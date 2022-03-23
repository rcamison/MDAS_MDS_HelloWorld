FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
COPY ["src/HelloWorldApi", "src/HelloWorldApi"]
RUN dotnet restore "src/HelloWorldApi/HelloWorldApi.csproj"
COPY . .
WORKDIR "/src/HelloWorldApi"
RUN dotnet build -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "HelloWorldApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HelloWorldApi.dll"]