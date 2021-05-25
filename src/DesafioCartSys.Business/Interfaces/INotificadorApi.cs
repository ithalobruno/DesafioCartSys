using DesafioCartSys.Business.Notifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioCartSys.Business.Interfaces
{
   public interface INotificadorApi
   {
        bool TemNotificacao();
        List<NotificacaoApi> ObterNotificacao();
        void Handle(NotificacaoApi notificacao);
   }
}
