using Producer.Helpers.Abstract;
using System.Net;
using System.Net.Sockets;

namespace Producer.Helpers.Concrete
{
    //TODO 7000 Port Numrası İçin Constant Sınıf Oluştur
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
}

