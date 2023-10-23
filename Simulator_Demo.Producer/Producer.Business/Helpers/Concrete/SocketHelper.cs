using Producer.Business.Helpers.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Producer.Business.Helpers.Concrete;

public class SocketHelper : ISocketHelper
{
    public List<Socket> CreateSocket(int clientNumber, List<Socket> sockets)
    {
        for (int i = 0; i < clientNumber; i++)
        {
            IPEndPoint clientEndPoint = new IPEndPoint(IPAddress.Loopback, 7000);
            Socket clientSocket = new Socket(SocketType.Stream, ProtocolType.Tcp);
            clientSocket.Bind(clientEndPoint);
            sockets.Add(clientSocket);
        }
        return sockets;
    }
}
