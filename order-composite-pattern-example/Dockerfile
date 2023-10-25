FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["order-composite-pattern-example/order-composite-pattern-example.csproj", "order-composite-pattern-example/"]
RUN dotnet restore "order-composite-pattern-example/order-composite-pattern-example.csproj"
COPY . .
WORKDIR "/src/order-composite-pattern-example"
RUN dotnet build "order-composite-pattern-example.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "order-composite-pattern-example.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "order-composite-pattern-example.dll"]
