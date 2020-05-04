# Grab a image made for dotnet core as base
FROM mcr.microsoft.com/dotnet/core/runtime:3.1-buster-slim AS base

# also saying that our working directory will be app
WORKDIR /app

# Grab a image made for dotnet core as build
FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build

# saying working directory will be source
WORKDIR /src

# copying all the files ending with .csproj and then running dotnet restore to download any dependency
COPY ["./myDockerPractise/myDockerPractise.csproj", "myDockerPractise/"]
RUN dotnet restore "myDockerPractise/myDockerPractise.csproj"

# copy or app files
COPY . .
WORKDIR "/src/myDockerPractise"

# then building our app files
RUN dotnet build "myDockerPractise.csproj" -c Release -o /app/build

# publishing 
FROM build AS publish
RUN dotnet publish "myDockerPractise.csproj" -c Release -o /app/publish

FROM base AS final

# again setting the working directory
WORKDIR /app

# copyting from publish to app/publish
COPY --from=publish /app/publish .

# tells from where the application will start
ENTRYPOINT ["dotnet", "myDockerPractise.dll"]
