using System.Net.Sockets;

namespace Producer.Helpers.Abstract
{
    public interface ISocketHelper
    {
        List<Socket> CreateSocket(int clientNumber, List<Socket> sockets);
    }
}
