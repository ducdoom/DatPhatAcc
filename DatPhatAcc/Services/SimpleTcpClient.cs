using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DatPhatAcc.Services
{
    public class SimpleTcpClient
    {
        private TcpClient _client;
        private NetworkStream _stream;

        public SimpleTcpClient(string ip, int port)
        {
            _client = new TcpClient(ip, port);
            _stream = _client.GetStream();
            Console.WriteLine("Connected to the server.");
        }

        public void SendRequest(string request)
        {
            if (_stream.CanWrite)
            {
                byte[] clientMessageAsByteArray = Encoding.ASCII.GetBytes(request);
                _stream.Write(clientMessageAsByteArray, 0, clientMessageAsByteArray.Length);
                Console.WriteLine("Client sent his message - should be received by server");
            }
        }
    }
}
