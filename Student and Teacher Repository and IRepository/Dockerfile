#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Student and Teacher Repository and IRepository/Student and Teacher Repository and IRepository.csproj", "Student and Teacher Repository and IRepository/"]
RUN dotnet restore "Student and Teacher Repository and IRepository/Student and Teacher Repository and IRepository.csproj"
COPY . .
WORKDIR "/src/Student and Teacher Repository and IRepository"
RUN dotnet build "Student and Teacher Repository and IRepository.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Student and Teacher Repository and IRepository.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Student and Teacher Repository and IRepository.dll"]