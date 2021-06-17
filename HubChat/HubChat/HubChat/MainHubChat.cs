using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace HubChat
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            
            InitializeComponent();         
            userIPAddress = GetIPAddress();
            TwojNick.Text = userNick;
            TwojPort.Text = userPort.ToString();
            TwojeIP.Text = userIPAddress.ToString();
            IPSerwera.Text = serverIPAddress;
            PortSerwera.Text = serverPort.ToString();
            op = new Opcje();
            ListenServer = false;
        }

        //   ZMIENNE \\
        private TcpClient newClient;
        private IPAddress userIPAddress;
        private int userPort = 1024;
        private String userNick = "Gość";
        private String otherUserNick = "Server";
        Opcje op;
        private String serverIPAddress = "";
        private int serverPort = 1024;
        Pakiet paka;
        private BinaryWriter writer;
        Boolean ListenServer;
    //    private BinaryReader reader;
        private int PanelLocationX = 3;

    
        private IPAddress GetIPAddress()
        {
            IPHostEntry hostEntry = Dns.GetHostEntry(Environment.MachineName);

            foreach (IPAddress address in hostEntry.AddressList)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                    return address;
            }

            return null;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CreateMessagePanel(String userNazwa, String userWiadomosc)
        {
            Panel panel = new Panel();
                    //Label nick = new Label();
            TextBox nick = new TextBox();
                    //Label wiadomosc = new Label();
            TextBox wiadomosc = new TextBox();
            // ustawienie panelu zielonego przy wysyłaniu wiadomości
            panel.Size = new Size(694, 70);
            panel.Location = new Point(3, PanelLocationX + 76);
            panel.BackColor = Color.DarkSeaGreen;
            // ustawienie na paneli Nicku
            nick.Location = new Point(3, 7);
            nick.Text = userNazwa;
            nick.Font = new Font(nick.Font, FontStyle.Bold);

            nick.ReadOnly = true;
            nick.BorderStyle = 0;
            nick.BackColor = Color.DarkSeaGreen;
            nick.TabStop = false;

            // Ustawienie na palenu wyświatlania wiadomości
            wiadomosc.Location = new Point(13, 29);
            wiadomosc.Size = new Size(680, 50);
            wiadomosc.Text = userWiadomosc;

            wiadomosc.ReadOnly = true;
            wiadomosc.BorderStyle = 0;
            wiadomosc.BackColor = Color.DarkSeaGreen;
            wiadomosc.TabStop = false;
            // dodanie do paneli nicku i wiadomosci
            panel.Controls.Add(nick);
            panel.Controls.Add(wiadomosc);
            // wstawienie panelu do okna
            
            MainChatWindow.Invoke(new Action(() => MainChatWindow.Controls.Add(panel)));
            // BŁĘDNE:   MainChatWindow.Controls.Add(panel);
            // auto scroll
            panel.Invoke(new Action(() => panel.Focus()));
            //panel.Focus();
            // pozycja
            PanelLocationX += 76;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Send_Click(object sender, EventArgs e)
        {
            if (ChatText.Text != "")
            {              
                try
                {
                    // BinaryWriter writer = new BinaryWriter(newClient.GetStream());
                    writer.Write(userNick);
                    writer.Write(ChatText.Text);


                    /*
                    if (ListenServer)
                    {
                        Task.Run(() =>
                        {
                            ReadMessage();
                        });
                        ListenServer = false;
                    }
                    */

                    ChatText.Text = "";
                    ChatText.Focus();
                }
                catch (Exception)
                {
                    MessageBox.Show("Nie można wysłać wiadomości.", "Błąd!");
                }            
            }
            else
            {
                MessageBox.Show("Nie można wysłać pustej wiadomości.","Uwaga!");
            }
        }

        private void Option_Click(object sender, EventArgs e)
        {
            paka = new Pakiet(serverIPAddress, serverPort, userNick, userPort);          
            op.ShowDialog();
            op.SetConfig(paka);

            this.serverIPAddress = paka.AdresIPServera;
            this.serverPort = paka.PortServera;
            this.userNick = paka.UserNick;
            this.userPort = paka.ClientPort;

            TwojNick.Text = userNick;
            TwojPort.Text = userPort.ToString();
            TwojeIP.Text = userIPAddress.ToString();

            IPSerwera.Text = serverIPAddress;
            PortSerwera.Text = serverPort.ToString();           
        }


        private void ReadMessage()
        {            
            while (true)
            {
                try
                {
                    BinaryReader reader = new BinaryReader(newClient.GetStream());
                    otherUserNick = reader.ReadString();
                    String odczyt = reader.ReadString();
                    CreateMessagePanel(otherUserNick, odczyt);
                }
               catch (Exception e)
                {
                    //MessageBox.Show("Nie można odczytać wiadomości. Utracono połączenie.\n" + e.ToString(), "Błąd!");
                    newClient.Close();   
                    break;
                }
            }
        }

        private void Connect_Click(object sender, EventArgs e)
        {

            if (Connect.Text == "Połącz")
            {

                if (serverIPAddress != "")
                {
                    try
                    {
                        IPAddress.Parse(serverIPAddress);

                        Connect.Text = "Rozłącz";
                        Option.Hide();
                        ChatClear.Hide();
                        newClient = new TcpClient();
                        try
                        {
                            newClient.Connect(serverIPAddress, serverPort);
                            ListenServer = true;
                            writer = new BinaryWriter(newClient.GetStream());
                            if (ListenServer)
                            {
                                Task.Run(() =>
                                {
                                    ReadMessage();
                                });
                                ListenServer = false;
                            }


                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Nie można połączyć się z serwerem.", "Błąd z połaczeniem!");
                            Option.Show();
                            Connect.Text = "Połącz";
                            return;
                        }
                        
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Podany adres serwera jest niepoprawny.", "Błąd!");
                        Option.Show();
                        Connect.Text = "Połącz";
                        return;
                    }

                }
                else
                {
                    MessageBox.Show("Proszę podać adres serwera.", "Uwaga!");
                    return;
                }
            }
            else if(Connect.Text == "Rozłącz")
            {
                Option.Show();
                ChatClear.Show();
                newClient.Close();
                Connect.Text = "Połącz";
            }
        }

        private void ChatClear_Click(object sender, EventArgs e)
        {
            MainChatWindow.Controls.Clear();
        }
    }
}
