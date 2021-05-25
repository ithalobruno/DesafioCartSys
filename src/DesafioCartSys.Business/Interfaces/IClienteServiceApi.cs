using DesafioCartSys.Business.Models;
using System;
using System.Threading.Tasks;

namespace DesafioCartSys.Business.Interfaces
{
    public interface IClienteServiceApi :IDisposable
    {
        Task Adicionar(Cliente cliente);

        Task Atualizar(Cliente cliente);

        Task Remover(Guid id);

    }
}
