using Producer.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producer.Entities.Concrete;

public class SocketDataModel : IEntity
{
    public int SocketUniqueNumber { get; set; }
    public int Timestamp { get; set; }
    public int RandomValue { get; set; }
}
