@echo off
set /p migrationId="migration to downgrade towards: "
dotnet ef database update %migrationId% --configuration Release --context PortalDataContext --project "./SchoolSystem1.Infrastructure.csproj" --startup-project "../SchoolSystem1/SchoolSystem1.csproj"
