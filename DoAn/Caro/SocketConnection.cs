using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace DoAn.Caro
{
    public class SocketConnection
    {
        Socket client;
        public bool ConnectServer() //bên Client sẽ connect server
        {
            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse(IP), port);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                client.Connect(ipep);
                return true;
            }
            catch
            {
                return false;
            }
        }

        Socket server;
        private List<Socket> connectionClient = new List<Socket>();
        public bool checkIsConnect()
        {
            if (connectionClient.Count == 0) return false;
            else return true;
        } 
        public void resetList()
        {
            connectionClient.Clear();
            connectionClient = new List<Socket>();
        }    
        public void CreateServer() //bên Server sẽ tạo server để Client connect tới
        {
            try
            {
                IPEndPoint ipep = new IPEndPoint(IPAddress.Parse(IP), port);
                server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                server.Bind(ipep);
                server.Listen(10);

                Thread acceptClient = new Thread(() =>
                {
                    try
                    {
                        client = server.Accept();
                        connectionClient.Add(client);
                    }
                    catch (SocketException se)
                    {
/*                        if (se.SocketErrorCode != SocketError.Interrupted)
                        {
                            MessageBox.Show(se.ToString());
                        }*/
                    }
                });
                acceptClient.IsBackground = true;
                acceptClient.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        public string IP = "127.0.0.1";
        public int port = 30000;
        public const int buffer = 1024;
        public bool isServer = true;

        public void setPort(int a)
        {
            port = a;
        }





        public bool Send(object data)
        {
            byte[] sendData = SerializeData(data);
            return SendData(client, sendData);
        }

        public object Receive()
        {
            byte[] receiveData = new byte[buffer];
            bool isOk = ReceiveData(client, receiveData);
            return DeserializeData(receiveData);
        }


        public bool SendData(Socket target, byte[] data)
        {
            if (target == null)
            {
                CloseConnect();
                return false;
            }
            try
            {
                return target.Send(data) == 1 ? true : false;
            }
            catch { return false; }
        }

        public bool ReceiveData(Socket target, byte[] data)
        {
            if (target == null)
            {
                CloseConnect();
                return false;
            }
            return target.Receive(data) == 1 ? true : false;
        }

        public void CloseConnect()
        {
            if (client != null && client.Connected)
            {
                try
                {
                    client.Shutdown(SocketShutdown.Both);
                    client.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            client?.Close();
            server?.Close();
        }


        public byte[] SerializeData(Object ob)
        {
            MemoryStream ms = new MemoryStream();
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(ms, ob);
            return ms.ToArray();
        }

        public object DeserializeData(byte[] byteArray)
        {
            MemoryStream ms = new MemoryStream(byteArray);
            BinaryFormatter bf = new BinaryFormatter();
            ms.Position = 0; // vị trí đầu dãy
            return bf.Deserialize(ms);
        }
        public string GetLocalIPv4()
        {
            string wirelessIPAddress = null;

            var networkInterfaces = NetworkInterface.GetAllNetworkInterfaces()
                .Where(n => n.OperationalStatus == OperationalStatus.Up);

            foreach (var networkInterface in networkInterfaces)
            {
                if (networkInterface.NetworkInterfaceType == NetworkInterfaceType.Wireless80211)
                {
                    var properties = networkInterface.GetIPProperties();

                    var addresses = properties.UnicastAddresses
                        .Where(a => a.Address.AddressFamily == AddressFamily.InterNetwork);

                    foreach (var address in addresses)
                    {
                        wirelessIPAddress = address.Address.ToString();
                        break;
                    }
                    if (!string.IsNullOrEmpty(wirelessIPAddress))
                    {
                        break;
                    }
                }
            }

            return wirelessIPAddress;
        }
    }

}
