using Producer.Model.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producer.Helpers.Abstract
{
    public interface IDataHelper
    {
        List<SocketDataModel> CreateDataModel(int dataNumber, Random rnd);
    }
}
