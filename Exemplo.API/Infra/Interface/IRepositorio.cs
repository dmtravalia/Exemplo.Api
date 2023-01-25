using System.Collections.Generic;

namespace Exemplo.API.Infra.Interface
{
    public interface IRepositorio<T> where T : class
    {
        void Adicionar(T produto);
        List<T> Listar();
    }
}