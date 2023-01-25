using System.ComponentModel.DataAnnotations;

namespace Exemplo.API.ViewModel
{

    public class AdicionarProdutoVM
    {
        [Required]
        public string Nome { get; set; }

        [Required]
        public decimal Preco { get; set; }

        [Required]
        public decimal Quantidade { get; set; }
    }
}