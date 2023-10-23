using Producer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Producer.Business.Abstract;

public interface ISimulationService
{
    public void CreateSimulation(int clientNumber, Random rnd, List<SocketDataModel> socketDataModels, List<Socket> sockets);
}
