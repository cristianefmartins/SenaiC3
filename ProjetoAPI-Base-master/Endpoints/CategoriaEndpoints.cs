using FluentValidation;
using Microsoft.EntityFrameworkCore;
using ProjetoAPI.Context;
using ProjetoAPI.DTO;
using ProjetoAPI.Model;

namespace ProjetoAPI.Endpoints
{
    public static class CategoriaEndpoints
    {
        public static void MapCategoriaEndpoints(this WebApplication app)
        {
            app.MapGet("/categorias", async (ProdutosDbContext db) =>
            {
                return await db.Categorias.ToListAsync();
            });


            app.MapPost("/categorias", async (Categoria cat, ProdutosDbContext db) =>
            {
                db.Categorias.Add(cat);
                await db.SaveChangesAsync();
                return Results.Created();
            });
        }
    }
}
