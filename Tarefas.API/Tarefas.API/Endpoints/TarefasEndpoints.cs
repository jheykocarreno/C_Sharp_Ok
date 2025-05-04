using Microsoft.EntityFrameworkCore;
using Tarefas.API.Context;
using Tarefas.API.Model;

namespace Tarefas.API.Endpoints
{
    public static class TarefasEndpoints
    {
        public static void MapTarefasEndpoints(this WebApplication app)
        {

            app.MapGet("/Tarefas", async (TarefasDbContext db) =>
                await db.Tarefas.ToListAsync());

            app.MapGet("/Tarefas/{id}", async (Guid id, TarefasDbContext db) =>
                await db.Tarefas.FindAsync(id) is Tarefa tarefa
                ? Results.Ok(tarefa)
                : Results.NotFound());

            app.MapPost("/Tarefas", async (Tarefa tarefa, TarefasDbContext db) =>
            {
                if (tarefa == null) return Results.BadRequest("Requisicao Invalida");
                
                var categoria = await db.Categorias.FindAsync(tarefa.CategoriaId);
                if (categoria is null) return Results.NotFound("Categoria nao existe");

                db.Tarefas.Add(tarefa);
                await db.SaveChangesAsync();

                return Results.Created($"/Tarefas/{tarefa.Id}", tarefa);
            });

            app.MapPut("/Tarefas/{id}", async (Guid id, Tarefa tarefaAtualizada, TarefasDbContext db) =>
            {
                var tarefa = await db.Tarefas.FindAsync(id);

                if (tarefa == null) Results.NotFound();

                tarefa.Nome = tarefaAtualizada.Nome;
                tarefa.Detalhes = tarefaAtualizada.Detalhes;
                tarefa.Concluida = tarefa.Concluida;
                tarefa.CategoriaId = tarefa.CategoriaId;
                await db.SaveChangesAsync();
                return Results.NoContent();
            });

            app.MapDelete("/Tarefas/{id}", async (Guid id, TarefasDbContext db) =>
            {
                var tarefa = await db.Tarefas.FindAsync(id);

                if (tarefa == null) Results.NotFound();

                db.Tarefas.Remove(tarefa);
                await db.SaveChangesAsync();
                return Results.Ok("Tarefa Deletada com sucesso");
            });
        }
    }
}
