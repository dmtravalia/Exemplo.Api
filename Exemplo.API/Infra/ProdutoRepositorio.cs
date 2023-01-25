using Exemplo.API.Context;
using Exemplo.API.Infra.Interface;
using Exemplo.API.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Exemplo.API.Infra
{
    public class ProdutoRepositorio : IProdutoRepositorio
    {
        private readonly ApiContext _context;

        public ProdutoRepositorio(ApiContext context)
        {
            _context = context;
        }

        public void Adicionar(Produto produto)
        {
            _context.Produtos.Add(produto);
            _context.SaveChanges();
        }

        public List<Produto> Listar()
        {
            return _context.Produtos.AsNoTracking().ToList();
        }
    }
}