using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DatPhatAcc.Services
{
    public partial class SimpleTcpServer
    {
        private TcpListener _server;
        private TcpClient _client;
        private NetworkStream _stream;

        public SimpleTcpServer(string ip, int port)
        {
            _server = new TcpListener(IPAddress.Parse(ip), port);
            _server.Start();
            Console.WriteLine("Server has started on {0}:{1}, Waiting for a connection...", ip, port);

            _client = _server.AcceptTcpClient();
            Console.WriteLine("A client connected.");

            _stream = _client.GetStream();
        }

        public void Listen()
        {
            while (true)
            {
                while (!_stream.DataAvailable) ;

                byte[] bytes = new byte[_client.Available];
                _stream.Read(bytes, 0, bytes.Length);
                string data = Encoding.UTF8.GetString(bytes);

                Console.WriteLine(data);
            }
        }
    }
}
