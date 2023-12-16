using FluentValidation.AspNetCore;
using Infra_Data.Context;
using Infra_Data.Repositories;
using Manager.Implementation;
using Manager.Interfaces;
using Manager.Validation;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
#pragma warning disable CS0618 // O tipo ou membro é obsoleto
builder.Services.AddControllers()
    .AddFluentValidation(p =>
    {
        p.RegisterValidatorsFromAssemblyContaining<LivroValidator>();
        p.ValidatorOptions.LanguageManager.Culture = new CultureInfo("pt-BR");
    });
#pragma warning restore CS0618 // O tipo ou membro é obsoleto

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddDbContext<CTX>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Conn")));

builder.Services.AddScoped<ILivroRepository, LivroRepository>();
builder.Services.AddScoped<ILivroManager, LivroManager>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Livraria", Version = "v1" });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.RoutePrefix = string.Empty;
        c.SwaggerEndpoint("./swagger/v1/swagger.json", "CL V1");
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
