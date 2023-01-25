using Exemplo.API.Infra.Interface;
using Exemplo.API.Model;
using Exemplo.API.Services.Interface;
using Exemplo.API.ViewModel;
using System.Collections.Generic;
using System.Linq;

namespace Exemplo.API.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepositorio _produtoRepositorio;

        public ProdutoService(IProdutoRepositorio produtoRepositorio)
        {
            _produtoRepositorio = produtoRepositorio;
        }

        public void AdicionarProduto(AdicionarProdutoVM produtoVM)
        {
            var produto = new Produto() { Nome = produtoVM.Nome, Quantidade = produtoVM.Quantidade, Preco = produtoVM.Preco };
            _produtoRepositorio.Adicionar(produto);
        }

        public List<ProdutoVM> Listar()
        {
            return _produtoRepositorio.Listar().Select(x => new ProdutoVM()
            {
                Id = x.Id,
                Nome = x.Nome,
                Quantidade = x.Quantidade,
                Preco = x.Preco,
            }).ToList();
        }
    }
}