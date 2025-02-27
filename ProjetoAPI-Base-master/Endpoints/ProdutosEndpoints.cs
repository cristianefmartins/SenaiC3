using FluentValidation;
using Microsoft.EntityFrameworkCore;
using ProjetoAPI.Context;
using ProjetoAPI.DTO;
using ProjetoAPI.Model;
using System.ComponentModel.DataAnnotations;

namespace ProjetoAPI.Endpoints
{
    public static class ProdutosEndpoints
    {
        public static void MapProdutosEndpoints(this WebApplication app)
        {
            app.MapGet("/produtos", async (ProdutosDbContext db) =>
            //traz a descricao da categoria
            await db.Produtos.Include(x => x.Categoria).ToListAsync());

            app.MapGet("/produtos/{id}", async (Guid id, ProdutosDbContext db) =>
                await db.Produtos.FindAsync(id)
                    is Produto produto
                        ? Results.Ok(produto)
                        : Results.NotFound()
            )
            //Essa eh a documentacao que aparece no swagger, dizendo o que esse endpoint pode retornar
            .Produces<Produto>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status404NotFound);


            app.MapPost("/produtos", async (ProdutoDto prod, IValidator<Produto> validator, ProdutosDbContext db) =>
            {
                if (prod != null)
                {

                    //pra cadastrar no banco eu preciso de cadastrar um Produto e nao um ProdutoDto
                    var produto = new Produto()
                    {
                        Nome = prod.Nome,
                        Valor = prod.Valor,
                        Descricao = prod.Descricao,
                        CategoriaId = prod.CategoriaId, 
                    };

                    // Validando no Cadastro 
                    var validation = await validator.ValidateAsync(produto);

                    if (!validation.IsValid) return Results.ValidationProblem(validation.ToDictionary());

                    db.Produtos.Add(produto);
                    await db.SaveChangesAsync();

                    return Results.Created($"/produtos/{produto.Id}", produto);
                }
                else
                {
                    return Results.BadRequest("Requisição Inválida!");
                }
            })
            //Essa eh a documentacao que aparece no swagger, dizendo o que esse endpoint pode retornar
            .Produces(StatusCodes.Status400BadRequest)
            .Produces<Produto>(StatusCodes.Status201Created);


            app.MapPut("/produtos/{id}", async (Guid id, Produto produto, IValidator<Produto> validator, ProdutosDbContext db) =>
            {
                var validation = await validator.ValidateAsync(produto);

                if (!validation.IsValid) return Results.ValidationProblem(validation.ToDictionary());

                var produtoEncontrado = await db.Produtos.FindAsync(id);

                if (produtoEncontrado is null) return Results.NotFound();

                produtoEncontrado.Nome = produto.Nome;
                produtoEncontrado.Valor = produto.Valor;
                produtoEncontrado.Descricao = produto.Descricao;
                produtoEncontrado.CategoriaId = produto.CategoriaId;

                await db.SaveChangesAsync();

                return Results.NoContent();
            })
            //Essa eh a documentacao que aparece no swagger, dizendo o que esse endpoint pode retornar
            .Produces(StatusCodes.Status204NoContent)
            .Produces(StatusCodes.Status400BadRequest)
            .Produces(StatusCodes.Status404NotFound);


            app.MapDelete("/produtos/{id}", async (Guid id, ProdutosDbContext db) =>
            {
                var produtoEncontrado = await db.Produtos.FindAsync(id);

                if (produtoEncontrado is null) return Results.NotFound();

                db.Produtos.Remove(produtoEncontrado);
                await db.SaveChangesAsync();
                return Results.Ok(produtoEncontrado);
            })
            //Essa eh a documentacao que aparece no swagger, dizendo o que esse endpoint pode retornar
            .Produces(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status404NotFound);
        }
    }
}
