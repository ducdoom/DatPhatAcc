using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ServerTCP
{
    public class ServerTCP
    {
        private readonly TcpListener tcpListener;

        public ServerTCP(int port)
        {
            tcpListener = new TcpListener(IPAddress.Any, port);
            tcpListener.Start();
            Debug.WriteLine($"Server started on port {port}");
        }

        public void Start()
        {
            //add cancel approach

        }
    }
}
