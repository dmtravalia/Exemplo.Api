using Exemplo.API.ViewModel;
using System.Collections.Generic;

namespace Exemplo.API.Services.Interface
{

    public interface IProdutoService
    {
        void AdicionarProduto(AdicionarProdutoVM produtoVM);
        List<ProdutoVM> Listar();
    }
}