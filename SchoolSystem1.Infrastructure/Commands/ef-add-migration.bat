@echo off
set /p name="Name: "
dotnet ef migrations add %name% --configuration Release --context SchoolDataContext --project "./SchoolSystem1.Infrastructure.csproj" --startup-project "../SchoolSystem1/SchoolSystem1.csproj"
