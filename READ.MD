#!Levantar base de datos
docker compose up -d

#! Ejecutar contenedor de C# .net
dotnet publish -c Release   
docker build -t luismartinez011/store-api-image -f Dockerfile . 
docker run -d -p 8080:8080 --name store-api-image luismartinez011/store-api-image

#! Ejecutar migraciones
dotnet ef migrations add AddImagesToProducts
dotnet ef database update