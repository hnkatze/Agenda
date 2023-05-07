using agenda;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
//construir y pasar la cadena de conexion a la base de datos
builder.Services.AddSqlServer<AgendaContext>("Data Source=localhost; Initial Catalog=AgendaDB; user id=sa; password=C4m1l1t0*; Encrypt=False; TrustServerCertificate=True");
var app = builder.Build();

app.MapGet("/", () => "Hola Mundo!");


//ENDPOINT URL que permite validar la existencia de la conexion a la base de SQL Server
app.MapGet("/conndb",([FromServices] AgendaContext dbContext) => {
dbContext.Database.EnsureCreated();
return Results.Ok("Base de datos Online");



});
app.Run();
