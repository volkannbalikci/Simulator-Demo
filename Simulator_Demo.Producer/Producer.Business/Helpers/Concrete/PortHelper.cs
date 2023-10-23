using Producer.Business.Helpers.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Producer.Business.Helpers.Concrete;

public class PortHelper : IPortHelper
{
    public Socket CreatePort()
    {
        IPEndPoint serverEndPoint = new IPEndPoint(IPAddress.Loopback, 7000);
        Socket welcomingPort = new Socket(SocketType.Stream, ProtocolType.Tcp);
        welcomingPort.Bind(serverEndPoint);
        return welcomingPort;
    }
}
