using Producer.Business.Helpers.Abstract;
using Producer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producer.Business.Helpers.Concrete;

public class DataHelper : IDataHelper
{
    public List<SocketDataModel> CreateDataModel(int clientNumber, Random rnd)
    {
        List<SocketDataModel> _sockets = new List<SocketDataModel>();
        for (int i = 0; i < clientNumber; i++)
        {
            Guid defaultSocketUniqueNumber = new Guid();
            int defaultRandomValue = rnd.Next(1, 3000), defaultTimeStamp = 0;
            SocketDataModel socketDataModel = new SocketDataModel()
            {
                SocketUniqueNumber = Convert.ToInt32(defaultSocketUniqueNumber),
                RandomValue = defaultRandomValue,
                Timestamp = 0
            };
            _sockets.Add(socketDataModel);
        }
        return _sockets;
    }
}
