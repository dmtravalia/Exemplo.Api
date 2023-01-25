using Exemplo.API.Context;
using Exemplo.API.Infra;
using Exemplo.API.Infra.Interface;
using Exemplo.API.Services;
using Exemplo.API.Services.Interface;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApiContext>(opt => opt.UseInMemoryDatabase("TestDb"));
builder.Services.AddScoped<IProdutoService, ProdutoService>();
builder.Services.AddScoped<IProdutoRepositorio, ProdutoRepositorio>();
builder.Services.AddScoped(typeof(IRepositorio<>), typeof(Repositorio<>));


// Explicar o que
// AddScoped(único durante toda a requisição)
// AddTransient(terá uma nova instância do objeto sempre que solicitado)
// AddSingleton(único dentro da aplicação)

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();