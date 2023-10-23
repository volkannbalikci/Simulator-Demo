using System.Net.Sockets;

namespace Producer.Helpers.Abstract
{
    public interface IPortHelper
    {
        Socket CreatePort();
    }
}
