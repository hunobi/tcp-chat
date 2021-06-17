using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubChat
{
   public class Pakiet
    {
        public Pakiet(string adresIPServera, int portServera, string userNick, int clientPort)
        {
            this.adresIPServera = adresIPServera;
            this.portServera = portServera;
            this.userNick = userNick;
            this.clientPort = clientPort;
        }

        public string AdresIPServera { get => adresIPServera; set => adresIPServera = value; }
        public int PortServera { get => portServera; set => portServera = value; }
        public string UserNick { get => userNick; set => userNick = value; }
        public int ClientPort { get => clientPort; set => clientPort = value; }

        private String adresIPServera;
        private int portServera;
        private String userNick;
        private int clientPort;
    }
}
