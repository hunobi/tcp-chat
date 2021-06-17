using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Threading;

namespace Server
{
    class Program
    {
        
        class TcpServer
        {
            public TcpServer(int port)
            {
                portServera = port;

              // Inicjalizacja
                this.listener = new TcpListener(IPAddress.Parse("0.0.0.0"), portServera);
            }


            private static int portServera;
            private TcpClient newClient;
            private TcpListener listener;
            private List<TcpClient> userList = new List<TcpClient>();
           

            public void Start()
            {
                Console.WriteLine("Trwa uruchamianie servera..");
                listener.Start();
                Console.WriteLine("Trwa oczekiwanie na połączenie..\n");
               
                while (true)
                {
                    newClient = listener.AcceptTcpClient();
                    Task.Run(() =>
                    {                     
                        userList.Add(newClient);
                        Console.WriteLine("Ilość: "+ userList.Count);
                        Connector();
                    });
                }
                
            }


            private void Connector()
            {
                Console.WriteLine("Nawiązano połączenie z Clientem.");
                BinaryReader reader = new BinaryReader(newClient.GetStream());
                String UserNick = "";

                var ClientPort = ((IPEndPoint)newClient.Client.RemoteEndPoint).Port.ToString();
                var ClientIP = ((IPEndPoint)newClient.Client.RemoteEndPoint).Address.ToString();
                String ClientID = ClientIP + ":" + ClientPort;
                while (true)
                {
                    try
                    {
                        UserNick = reader.ReadString();
                        String message = reader.ReadString();
                        Console.WriteLine("[{0}:{1}] {2} >>  " + message, ClientIP, ClientPort, UserNick);

                    
                        if (message == "\\show")
                        {
                            Console.WriteLine("\nLista połączonych klientów: ");
                            foreach (TcpClient client in userList)
                            {
                                String ID = (((IPEndPoint)client.Client.RemoteEndPoint).Address.ToString()) + ":" + (((IPEndPoint)client.Client.RemoteEndPoint).Port.ToString());
                                Console.WriteLine("User ID:  " + ID);
                               
                            }                           
                        }
                        else if (message == "\\stop_server")
                        {
                            Environment.Exit(0);
                        }
                        else if (message == "\\clear")
                        {   
                            for(int i = 0; i < userList.Count; i++)
                            {
                                string ID = ((IPEndPoint)userList.ElementAt(i).Client.RemoteEndPoint).Address.ToString() + ":" + ((IPEndPoint)userList.ElementAt(i).Client.RemoteEndPoint).Port.ToString();                            
                                if (ClientID != ID)
                                {
                                    Console.WriteLine("Wywalam USER o ID:  >>  " + ID);
                                    userList.ElementAt(i).Close();
                                    userList.Remove(userList.ElementAt(i));
                                }
                            }                            
                        }
                        else if (message == "\\clear_all")
                        {
                            foreach(TcpClient client in userList)
                            {
                                String ID = (((IPEndPoint)client.Client.RemoteEndPoint).Address.ToString()) + ":" + (((IPEndPoint)client.Client.RemoteEndPoint).Port.ToString());
                                Console.WriteLine("Wywalam USER o ID:  >>  " + ID);
                                client.Close();
                            }
                            userList.Clear();
                        }
                        else
                        {
                            foreach (TcpClient client in userList)
                            {
                                BinaryWriter writer = new BinaryWriter(client.GetStream());
                                writer.Write(UserNick);
                                writer.Write(message);
                            }
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("[{0}] :: Utracono połączenie z klientem.",UserNick);
                        try
                        {                           
                            foreach (TcpClient client in userList)
                            {
                                String ID = (((IPEndPoint)client.Client.RemoteEndPoint).Address.ToString()) + ":" + (((IPEndPoint)client.Client.RemoteEndPoint).Port.ToString());                               
                                if (ClientID.Equals(ID))
                                {
                                    client.Close();
                                    userList.Remove(client);
                                }
                            }                         
                        }
                        catch (Exception)
                        {                          
                        }
                        break;
                    } // koniec Catch
                } // koniec pętli WHILE
            } // koniec Connector()
        }

        static void Main(string[] args)
        {
            TcpServer server = new TcpServer(1024);
            server.Start();
            Console.WriteLine("\nTrwa zamykanie servera..");
            Console.ReadKey();
        }
    }
}
