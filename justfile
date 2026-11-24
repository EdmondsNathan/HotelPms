default:
  @just --list

watch-backend:
  dotnet watch run --project backend/src/HotelPms.Api
