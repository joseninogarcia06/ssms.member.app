FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /app

# Copy solution file first
COPY *.slnx ./

# Copy all project folders
COPY ssms.member.app/*.csproj ./ssms.member.app/
COPY ssms.member.domain/*.csproj ./ssms.member.domain/
COPY ssms.member.repository/*.csproj ./ssms.member.repository/
COPY ssms.member.test/*.csproj ./ssms.member.test/

# Restore all
RUN dotnet restore

# Copy rest of the code
COPY . ./

# Publish
RUN dotnet publish ssms.member.app/ssms.member.app.csproj -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:10.0
WORKDIR /app
COPY --from=build /app/out .

EXPOSE 85
ENTRYPOINT ["dotnet", "ssms.member.app.dll"]