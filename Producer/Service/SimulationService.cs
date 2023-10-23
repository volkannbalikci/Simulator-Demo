using Producer.Helpers.Abstract;
using Producer.Helpers.Concrete;
using Producer.Model.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Producer.Service
{
    public class SimulationService
    {
        IDataHelper _dataHelper;
        IPortHelper _portHelper;
        ISocketHelper _socketHelper;
        public SimulationService(IDataHelper dataHelper, IPortHelper portHelper, ISocketHelper socketHelper)
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

            // wait for connection
            port.Listen();
            Socket connectionSocket = port.Accept();

            //Display received data
            
            
            //5 tane veri geldiyse, her bir soketten bir tane veri gönderilecek. bu gönderme işlemi 1 kere yapıldığında her bir soketten gönderilen veri tekrar güncellenerek yeniden bir gönderim işlemi olacak X soketi Y verisini gönderdiğinde sonraki saniyelerde de Y verisinin güncellenmiş halini göndermeye devam edecek.



            //Son Aşama
            //RabbitMQ.SendDataToQueue(datasToBeSent, "SocketDatasQueue");  (En Son Aşamam)
            //Son Aşama
        }
    }
}
