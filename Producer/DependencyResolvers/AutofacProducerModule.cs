using Autofac;
using Producer.Helpers.Abstract;
using Producer.Helpers.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producer.DependencyResolvers
{
    public class AutofacProducerModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<DataHelper>().As<IDataHelper>().SingleInstance();
            builder.RegisterType<PortHelper>().As<IPortHelper>().SingleInstance();
            builder.RegisterType<SocketHelper>().As<ISocketHelper>().SingleInstance();//client number. API 
        }
    }
}
