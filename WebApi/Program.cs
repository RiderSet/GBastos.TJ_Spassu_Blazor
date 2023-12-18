using Infra_Data.Context;
using Infra_Data.Repositories;
using Manager.Implementation;
using Manager.Interfaces.Livros;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors();

builder.Services.AddDbContext<CTX>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Conn"));
});

builder.Services.AddScoped<ILivroRepository, LivroRepository>();
builder.Services.AddScoped<ILivroManager, LivroManager>();
/*
builder.Services.AddScoped<IAutorRepository, AutorRepository>();
builder.Services.AddScoped<IAssuntoRepository, AssuntoRepository>();
*/

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(policy =>
    policy.WithOrigins("http://localhost:44317", "https://localhost:44317")
    .AllowAnyMethod()
    .AllowAnyHeader()
    .WithHeaders(HeaderNames.ContentType)
);

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();