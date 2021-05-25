using DesafioCartSys.Business.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DesafioCartSys.Business.Notifications
{
    public class NotificadorApi : INotificadorApi
    {
        private List<NotificacaoApi> _notificacoes;

        public NotificadorApi()
        {
            _notificacoes = new List<NotificacaoApi>();
        }
        public void Handle(NotificacaoApi notificacao)
        {
            _notificacoes.Add(notificacao);
        }

        public List<NotificacaoApi> ObterNotificacao()
        {
            return _notificacoes;
        }

        public bool TemNotificacao()
        {
            return _notificacoes.Any();
        }
    }
}
