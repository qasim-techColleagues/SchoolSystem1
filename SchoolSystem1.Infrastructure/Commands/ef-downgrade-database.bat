@echo off
set /p migrationId="migration to downgrade towards: "
dotnet ef database update %migrationId% --configuration Release --context PortalDataContext --project "./EE.Infrastructure.csproj" --startup-project "../EE.API/EE.API.csproj"
