using DesafioCartSys.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DesafioCartSys.API.Controllers
{
    public abstract class BaseController : ControllerBase
    {
        private readonly INotificadorApi _notificador;

        public BaseController(INotificadorApi notificador)
        {
            _notificador = notificador;
        }

        protected bool OperacaoValida()
        {
           return !_notificador.TemNotificacao();
        }

    }
}
