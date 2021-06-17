using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HubChat
{
    public partial class Opcje : Form
    {
        public Opcje()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {/*
            adresIPServera = AdressIP.Text;
            portServera = Convert.ToInt32(Port.Text);
            userNick = userNazwa.Text;
            clientPort = Convert.ToInt32(UserPort.Text);*/
            this.Hide();
        }

        private void AcceptData_Click(object sender, EventArgs e)
        {
            adresIPServera = AdressIP.Text;
            portServera = Convert.ToInt32(Port.Text);
            userNick = userNazwa.Text;
            clientPort = Convert.ToInt32(UserPort.Text);

            AdressIP.Text = adresIPServera;
            Port.Text = portServera.ToString();
            userNazwa.Text = userNick;
            UserPort.Text = clientPort.ToString();
            this.Hide();
        }

        public void SetConfig(Pakiet paka)
        {
            
            paka.AdresIPServera = this.adresIPServera;
            paka.PortServera = this.portServera;
            paka.UserNick = this.userNick;
            paka.ClientPort = this. clientPort;

        }

        private  String adresIPServera;
        private  int portServera;
        private  String userNick;
        private  int clientPort;
    }
}
