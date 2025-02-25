using Microsoft.EntityFrameworkCore;
using ProjetoAPI.Context;
using ProjetoAPI.Model;

namespace ProjetoAPI.Endpoints
{
    public static class ProdutosEndpoints
    {
        public static void MapProdutosEndpoints(this WebApplication app)
        {
            //Listar todos produtos
            //caminho pra acessar. Nos parentesis sempre poe a representacao do db
            app.MapGet("/produtos", async (ProdutoDbContext db) =>
            {
                //acessa o Produtos dentro de db e transforma em uma lista
                //await: o sistema continua executando outras atividades enquanto a lista esta sendo buscada
                return await db.Produtos.ToListAsync();
                //no get por padrao ele retorna 200
            });



            //Listar por id
            app.MapGet("/produtos/{id}", async (Guid id, ProdutoDbContext db) =>
            {
                return await db.Produtos.FindAsync(id);

                //outro metodo pra procurar. Serve pra busca customizada. Expressao lambda.
                //return await db.Produtos.FirstOrDefault(produto => produto.Nome == "X" && produto.Categoria = "Brinquedo");
            });


            //Cadastro, nod () alem do db eu preciso de cadastrar um produto
            app.MapPost("/produtos", async (Produto prod, ProdutoDbContext db) =>
            {
                db.Produtos.Add(prod);

                //EF - SaveChanges = efetiva acao
                await db.SaveChangesAsync();
                return Results.Created();
            }
            );

            /*
            //Exercicios
            //Listar todos produtos
            app.MapGet("/listarprodutos", async (ProdutoDbContext db) =>
            {
                return await db.Produtos.ToListAsync();
            });


            app.MapPost("/cadastrarprodutos", async (Produto prod, ProdutoDbContext db) =>
            {
                db.Produtos.Add(prod);
                await db.SaveChangesAsync();
                return Results.Created();
            }
            );*/


            /* 
            app.MapPut("/editarprodutos", async (Produto prod, ProdutoDbContext db) =>
            {
                db.Produtos.Update(prod);
                await db.SaveChangesAsync();
                return Results.Ok();
            }
            ); */


            app.MapDelete("/produtos/{id}", async (Guid id, ProdutoDbContext db) =>
            {
                //se achar ele joga o objeto dentro da variavel produtoEncontrado
                var produtoEncontrado = await db.Produtos.FindAsync(id);

                //if (produtoEncontrado == null) ou
                //se nao achar ele retorna o erro 404
                if (produtoEncontrado is null) return Results.NotFound();

                db.Produtos.Remove(produtoEncontrado);
                await db.SaveChangesAsync();

                //mostra o produto deletado
                return Results.Ok(produtoEncontrado);
            }
            );


            //                                  preciso do id, e qual a descricao nova do produto
            app.MapPut("/produtos/{id}", async (Guid id, Produto prod, ProdutoDbContext db) =>
            {
                //se achar ele joga o objeto dentro da variavel produtoEncontrado
                var produtoEncontrado = await db.Produtos.FindAsync(id);

                //if (produtoEncontrado == null) ou
                //se nao achar ele retorna o erro 404
                if (produtoEncontrado is null) return Results.NotFound();

                produtoEncontrado.Nome = prod.Nome;
                produtoEncontrado.Categoria = prod.Categoria;
                await db.SaveChangesAsync();

                //mostra o produto deletado
                return Results.Ok(produtoEncontrado);
            }
            );
        }


    }
}
