using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalRTest.Hubs
{
    public class Chat : Hub
    {
        public void EnviarMensagem(string apelido, string mensagem)
    {
        Clients.TransmitirMensagem(apelido, mensagem);
    }

}
}