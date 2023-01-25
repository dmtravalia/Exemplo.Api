using Exemplo.API.Model;
using Microsoft.EntityFrameworkCore;

namespace Exemplo.API.Context
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {
        }

        public DbSet<Produto> Produtos { get; set; }
    }
}