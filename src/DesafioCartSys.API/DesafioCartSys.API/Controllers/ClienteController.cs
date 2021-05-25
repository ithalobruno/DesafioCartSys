using DesafioCartSys.Business.Interfaces;
using DesafioCartSys.Business.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace DesafioCartSys.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : BaseController
    {
        private readonly IClienteRepositorioApi _clienteRepositorio;
        private readonly IClienteServiceApi _clienteService;
        
        public ClienteController(IClienteRepositorioApi clienteRepositorio,
                                      IClienteServiceApi clienteService,
                                      
        INotificadorApi notificador) : base(notificador)
        {
            _clienteRepositorio = clienteRepositorio;
            _clienteService = clienteService;
            
        }

        [HttpGet]
        public async Task<ActionResult<List<Cliente>>> ObterTodos()
        {
            return await _clienteRepositorio.ObterTodos();
        }

        
    }
}
