using Producer.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producer.Model.Concrete
{
    public class SocketDataModel : IModel
    {
        public int SocketUniqueNumber { get; set; }
        public int Timestamp { get; set; }
        public int RandomValue { get; set; }
    }
}
