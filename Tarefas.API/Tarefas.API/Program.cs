using Tarefas.API.Context;
using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore;
using Tarefas.API.Model;
using Tarefas.API.Endpoints;

var builder = WebApplication.CreateBuilder(args);

var connectionString = "Data Source=Tarefas.db";
builder.Services.AddSqlite<TarefasDbContext>(connectionString);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "API de Tarefas",
        Version = "v1",
        Description = "API do Projeto de Tarefas para aprendizado de desenvolvimento Backend"
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("v1/swagger.json", "API Tarefas v1");
    });
}

app.UseHttpsRedirection();

app.MapCategoriasEndPoints();

app.MapTarefasEndpoints();

app.Run();
