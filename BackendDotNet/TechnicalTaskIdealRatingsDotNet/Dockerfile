﻿FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["BackendDotNet/TechnicalTaskIdealRatingsDotNet/TechnicalTaskIdealRatingsDotNet.csproj", "TechnicalTaskIdealRatingsDotNet/"]
RUN dotnet restore "TechnicalTaskIdealRatingsDotNet/TechnicalTaskIdealRatingsDotNet.csproj"
COPY . .
WORKDIR "/src/BackendDotNet/TechnicalTaskIdealRatingsDotNet"
RUN dotnet build "TechnicalTaskIdealRatingsDotNet.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "TechnicalTaskIdealRatingsDotNet.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
COPY BackendDotNet/TechnicalTaskIdealRatingsDotNet/Data/person.csv ./Data/person.csv
ENTRYPOINT ["dotnet", "TechnicalTaskIdealRatingsDotNet.dll"]
