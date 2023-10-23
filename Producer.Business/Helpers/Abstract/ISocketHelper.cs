using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Producer.Business.Helpers.Abstract;

public interface ISocketHelper
{
    List<Socket> CreateSocket(int clientNumber, List<Socket> sockets);
}
