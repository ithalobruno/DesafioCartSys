using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DesafioCartSys.App.ViewModels;
using DesafioCartSys.Business.Interfaces;
using AutoMapper;
using DesafioCartSys.Business.Models;
using Microsoft.AspNetCore.Authorization;


namespace DesafioCartSys.App.Controllers
{
    public class ClienteController : BaseController
    {
        private readonly IClienteRepositorio _clienteRepositorio;
        private readonly IClienteService _clienteService;
        private readonly IMapper _mapper;

        public ClienteController(IClienteRepositorio clienteRepositorio, 
                                      IMapper mapper,
                                      IClienteService clienteService,
                                      INotificador notificador) : base(notificador)
        {
            _clienteRepositorio = clienteRepositorio;
            _clienteService = clienteService;
            _mapper = mapper;
        }

        [Route("lista-de-clientes")]
        public async Task<IActionResult> Index()
        {
            return View(_mapper.Map<IEnumerable<ClienteViewModel>>(await _clienteRepositorio.ObterTodos()));
        }

        
       
        [Route("novo-cliente")]
        public IActionResult Create()
        {
            return View();
        }

        [Route("novo-cliente")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ClienteViewModel clienteViewModel)
        {
            if (!ModelState.IsValid) return View(clienteViewModel);

            var cliente = _mapper.Map<Cliente>(clienteViewModel);
            await _clienteService.Adicionar(cliente);

            if (!OperacaoValida()) return View(clienteViewModel);

            return RedirectToAction(nameof(Index));
           
        }

        [Route("editar-cliente/{id:guid}")]
        public async Task<IActionResult> Edit(Guid id)
        {
            var clienteViewModel = await _clienteRepositorio.ObterPorId(id);
            if (clienteViewModel == null)
            {
                return NotFound();
            }
            return View(_mapper.Map<ClienteViewModel>(await _clienteRepositorio.ObterPorId(id)));
            
        }

        [Route("editar-cliente/{id:guid}")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, ClienteViewModel clienteViewModel)
        {
            if (id != clienteViewModel.Id) return NotFound();

            if (!ModelState.IsValid) return View(clienteViewModel);

            var cliente = _mapper.Map<Cliente>(clienteViewModel);
            await _clienteService.Atualizar(cliente);

            if (!OperacaoValida()) return View(await _clienteRepositorio.ObterPorId(id));
            return RedirectToAction(nameof(Index));
            
        }

        [Route("excluir-fornecedor/{id:guid}")]
        public async Task<IActionResult> Delete(Guid id)
        {

            var clienteViewModel = await _clienteRepositorio.ObterPorId(id);

            if (clienteViewModel == null)
            {
                return NotFound();
            }

            return View(clienteViewModel);
        }

        [Route("editar-fornecedor/{id:guid}")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var clienteViewModel = await _clienteRepositorio.ObterPorId(id);

            if (clienteViewModel == null) return NotFound();

            await _clienteService.Remover(id);
            if (!OperacaoValida()) return View(clienteViewModel);

            return RedirectToAction(nameof(Index));
        }

        
    }
}
