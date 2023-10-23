using Producer.Business.Abstract;
using Producer.Business.Helpers.Abstract;
using Producer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Producer.Business.Concrete;

public class SimulationManager : ISimulationService
{
    IDataHelper _dataHelper;
    IPortHelper _portHelper;
    ISocketHelper _socketHelper;

    public SimulationManager(IDataHelper dataHelper, IPortHelper portHelper, ISocketHelper socketHelper)
    {
        _dataHelper = dataHelper;
        _portHelper = portHelper;
        _socketHelper = socketHelper;
    }

    public void CreateSimulation(int clientNumber, Random rnd, List<SocketDataModel> socketDataModels, List<Socket> sockets)
    {
        var port = _portHelper.CreatePort();
        _socketHelper.CreateSocket(clientNumber, sockets);
        _dataHelper.CreateDataModel(clientNumber, rnd);
        port.Listen();
        Socket connectionSocket = port.Accept();
    }
}
