﻿using DesafioCartSys.Business.Notifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioCartSys.Business.Interfaces
{
   public interface INotificador
   {
        bool TemNotificacao();
        List<Notificacao> ObterNotificacao();
        void Handle(Notificacao notificacao);
   }
}
