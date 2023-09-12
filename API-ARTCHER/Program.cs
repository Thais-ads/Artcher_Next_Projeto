using API_ARTCHER.Data;
using API_ARTCHER.Models;

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddCors();
// Add services to the container.

//builder.Services.AddDbContext<CadastroContext>
//    (options => options.Use("Data Source=DESKTOP-O3M3AQG\\SQLEXPRESS;Initial Catalog=CRUD;Integrated Security=False;User ID=Pedro;Password=1234;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False"));
var stringConexao = "User Id=rm86889;Password=150397;Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST =oracle.fiap.com.br)(PORT=1521)))(CONNECT_DATA=(SERVICE_NAME=ORCL)))";
builder.Services.AddDbContext<CadastroContext>
    (options => options.UseOracle(stringConexao));



builder.Services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<CadastroContext>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();



    builder.Services.AddSwaggerGen(c =>
    {
        c.SwaggerDoc("v1", new OpenApiInfo { Title = "ArtcherAPI", Version = "v1" });
        var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
        var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
        c.IncludeXmlComments(xmlPath);
    });
;

var app = builder.Build();

app.UseAuthentication();
app.UseAuthorization();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(c =>
{
    c.AllowAnyHeader();
    c.AllowAnyMethod();
    c.AllowAnyOrigin();

});

   
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
