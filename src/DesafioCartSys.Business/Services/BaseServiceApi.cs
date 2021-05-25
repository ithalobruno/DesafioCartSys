using FluentValidation;
using FluentValidation.Results;
using DesafioCartSys.Business.Models;
using DesafioCartSys.Business.Interfaces;
using DesafioCartSys.Business.Notifications;

namespace DesafioCartSys.Business.Services
{
    public abstract class BaseServiceApi
    {
        private readonly INotificadorApi _notificador;

        public BaseServiceApi(INotificadorApi notificador)
        {
            _notificador = notificador;
        }
        protected void Notificar(ValidationResult validationResult)
        {
            foreach(var error in validationResult.Errors)
            {
                Notificar(error.ErrorMessage);
            }
        }

        protected void Notificar(string mensagem)
        {
            _notificador.Handle(new NotificacaoApi(mensagem));
        }

        protected bool ExecutarValidacao<TV, TE>(TV validacao, TE entidade) where TV : AbstractValidator<TE> where TE : Entidade
        {
            var validator = validacao.Validate(entidade);

            if(validator.IsValid) return true;

            Notificar(validator);
            return false;
        }

    }
}
