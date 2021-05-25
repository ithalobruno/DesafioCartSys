using System;
using System.Linq;
using System.Text;

namespace DesafioCartSys.Business.Notifications
{
    public class NotificacaoApi
    {
        public NotificacaoApi(string mensagem)
        {
            Mensagem = mensagem;
        }
        public string Mensagem { get; }
    }
}
