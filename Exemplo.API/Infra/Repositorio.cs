using Exemplo.API.Context;
using Exemplo.API.Infra.Interface;
using System.Collections.Generic;
using System.Linq;

namespace Exemplo.API.Infra
{
    public class Repositorio<T> : IRepositorio<T> where T : class
    {
        private readonly ApiContext _context;

        public Repositorio(ApiContext context)
        {
            _context = context;
        }

        public void Adicionar(T produto)
        {
            _context.Set<T>().Add(produto);
            _context.SaveChanges();
        }

        public List<T> Listar()
        {
            return _context.Set<T>().ToList();
        }
    }
}