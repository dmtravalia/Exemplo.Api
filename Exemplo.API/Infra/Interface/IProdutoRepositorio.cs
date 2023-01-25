using Exemplo.API.Model;
using System.Collections.Generic;

namespace Exemplo.API.Infra.Interface
{
    public interface IProdutoRepositorio
    {
        void Adicionar(Produto produto);
        List<Produto> Listar();
    }
}