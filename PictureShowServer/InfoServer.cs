using System;
using System.Net;
using System.Text;
using System.Threading;
using System.Net.Sockets;

namespace PictureShowServer
{
    internal class InfoServer
    {
        private IPAddress groupAddress;
        private int groupPort;
        private UnicodeEncoding encoding = new UnicodeEncoding();

        public InfoServer(IPAddress groupAddress, int groupPort)
        {
            this.groupAddress = groupAddress;
            this.groupPort = groupPort;
        }

        public void Start()
        {
            Thread infoThread = new Thread(InfoMain);
            infoThread.Start();
        }

        public void InfoMain()
        {
            string configuration = groupAddress.ToString() + ":" + groupPort.ToString();

            Socket infoSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                infoSocket.Bind(new IPEndPoint(IPAddress.Any, 8777));
                infoSocket.Listen(5);

                while (true)
                {
                    Socket clientSocket = infoSocket.Accept();
                    clientSocket.Send(encoding.GetBytes(configuration));
                    clientSocket.Shutdown(SocketShutdown.Both);
                    clientSocket.Close();
                }
            }
            finally
            {
                infoSocket.Shutdown(SocketShutdown.Both);
                infoSocket.Close();
            }
        }
    }
}
