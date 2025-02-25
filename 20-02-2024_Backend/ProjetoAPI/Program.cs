using Microsoft.EntityFrameworkCore;
using ProjetoAPI.Context;
using ProjetoAPI.Endpoints;
using ProjetoAPI.Model;

var builder = WebApplication.CreateBuilder(args);



// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

//ADD ESSAS 2 LINHAS
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var stringConexao = "Data Source=produtos.db";
builder.Services.AddSqlite<ProdutoDbContext>(stringConexao);

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();

    //ADD ESSAS 2 LINHAS
    app.UseSwagger();
    app.UseSwaggerUI();

}

app.UseHttpsRedirection();

app.MapProdutosEndpoints();

app.Run();
