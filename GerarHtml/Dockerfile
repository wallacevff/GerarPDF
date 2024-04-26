#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.


FROM 903987525052.dkr.ecr.us-east-1.amazonaws.com/netcore-runtime:7.0 AS base
RUN apt-get update
RUN apt-get upgrade -y
RUN apt-get install aptitude -y
RUN aptitude update
RUN aptitude install chromium procps htop -y
WORKDIR /app
EXPOSE 80
EXPOSE 443



FROM 903987525052.dkr.ecr.us-east-1.amazonaws.com/netcore-sdk:7.0 AS build
WORKDIR /src
COPY ["GerarHtml/GerarHtml.csproj", "GerarHtml/"]
RUN dotnet restore "GerarHtml/GerarHtml.csproj"
COPY . .
WORKDIR "/src/GerarHtml"
RUN dotnet build "GerarHtml.csproj" -c Release -o /app/build


FROM build AS publish
RUN dotnet publish "GerarHtml.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GerarHtml.dll"]