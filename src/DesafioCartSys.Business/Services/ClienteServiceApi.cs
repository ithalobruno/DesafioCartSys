using DesafioCartSys.Business.Interfaces;
using DesafioCartSys.Business.Models;
using DesafioCartSys.Business.Models.Validations;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioCartSys.Business.Services
{

    public class ClienteServiceApi : BaseServiceApi, IClienteServiceApi
    {
        private readonly IClienteRepositorioApi _clienteRepositorio;
        public ClienteServiceApi(INotificadorApi notificador, IClienteRepositorioApi clienteRepositorio) :base(notificador)
        {
            _clienteRepositorio = clienteRepositorio;

        }
        public async Task Adicionar(Cliente cliente)
        {
            
            if (!ExecutarValidacao(new ClienteValidation(), cliente) ) return;
           
            if (_clienteRepositorio.Buscar(f => f.Documento == cliente.Documento).Result.Any())
            {
                Notificar("Já existe um cliente com este documento informado");
                return;
            }

            await _clienteRepositorio.Adicionar(cliente);
        }

        public async Task Atualizar(Cliente cliente)
        {
            if (!ExecutarValidacao(new ClienteValidation(), cliente)) return;

            if(_clienteRepositorio.Buscar(f=> f.Documento == cliente.Documento && f.Id != cliente.Id).Result.Any())
            {
                Notificar("Já existe um cliente com este documento informado");
                return;
            }

            await _clienteRepositorio.Atualizar(cliente);
        }

        public async Task Remover(Guid id)
        {
          
            await _clienteRepositorio.Remover(id);
        }

        public void Dispose()
        {
            _clienteRepositorio?.Dispose();
        }
    }
}
