using Microsoft.AspNetCore.Components.Forms;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using MnemosyneAPI.Context;
using MnemosyneAPI.Model;
using FluentValidation;

namespace MnemosyneAPI.Endpoint
{
    public static class MemoriesEndpoints
    {
        public static void MapMemoriesEndpoints(this WebApplication app)
        {
            //Listar todas memories
            app.MapGet("/memories", async (MemoryDbContext db) =>
            {
                //await: o sistema continua executando outras atividades enquanto a lista esta sendo buscada
                 return await db.Memories.ToListAsync();

            });

            //Listar memory por id
            app.MapGet("/memories/{id}", async (int id, MemoryDbContext db) =>
                 await db.Memories.FindAsync(id) is Memory memory
                //Se a memory for do tipo memory, retorna ok.  Se for nulo ele retorna not found
                 ? Results.Ok(memory)
                 : Results.NotFound())
                .Produces<Memory>(StatusCodes.Status200OK)
                .Produces(StatusCodes.Status404NotFound);



            //Cadastrar memory
            //[Roles="Administrador"] autentificacao, nao vamos implementar
            app.MapPost("/memories", async (Memory memory, IValidator<Memory> validator, MemoryDbContext db) =>
            {
               if (memory == null) return Results.BadRequest("Requisição Inválida!");


               //as proximas 2 linhas estao relacionados com os validators
                var validation = await validator.ValidateAsync(memory);

                //esse IsValid eh um boolean. Exclamacao eh sinal de exclimacao. Se a validacao nao for valida
                if (!validation.IsValid) return Results.ValidationProblem(validation.ToDictionary());
      
                db.Memories.Add(memory);
                await db.SaveChangesAsync();
                return Results.Created($"/memories/{memory.Id}", memory);
            })
                .Produces<Memory>(StatusCodes.Status201Created)
                .Produces(StatusCodes.Status400BadRequest);


            //Editar memory
            app.MapPut("/memories/{id}", async (int id, Memory memory, IValidator<Memory> validator, MemoryDbContext db) =>
            {
                var memoryFound = await db.Memories.FindAsync(id);
                if (memoryFound is null) return Results.NotFound();

                //as proximas 2 linhas estao relacionados com os validators
                var validation = await validator.ValidateAsync(memory);

                //esse IsValid eh um boolean. Exclamacao eh sinal de exclimacao. Se a validacao nao for valida
                if (!validation.IsValid) return Results.ValidationProblem(validation.ToDictionary());

                memoryFound.Title = memory.Title;
                memoryFound.Description = memory.Description;
                memoryFound.Date = memory.Date;
                memoryFound.Images = memory.Images;

                await db.SaveChangesAsync();
                return Results.NoContent();
            })
                .Produces<Memory>(StatusCodes.Status204NoContent)
                .Produces(StatusCodes.Status404NotFound); 



            //Deletar memory
            app.MapDelete("/memories/{id}", async (int id, MemoryDbContext db) =>
            {
                var memoryFound = await db.Memories.FindAsync(id);
                if (memoryFound is null) return Results.NotFound();

                db.Memories.Remove(memoryFound);
                await db.SaveChangesAsync();
                return Results.Ok(memoryFound);
            })
                .Produces<Memory>(StatusCodes.Status200OK)
                .Produces(StatusCodes.Status404NotFound);


        }
    }
}
