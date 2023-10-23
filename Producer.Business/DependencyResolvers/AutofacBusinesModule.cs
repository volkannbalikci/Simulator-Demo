using Autofac;
using Producer.Business.Helpers.Abstract;
using Producer.Business.Helpers.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producer.Business.DependencyResolvers;

public class AutofacBusinesModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterType<DataHelper>().As<IDataHelper>().SingleInstance();
        builder.RegisterType<PortHelper>().As<IPortHelper>().SingleInstance();
        builder.RegisterType<SocketHelper>().As<ISocketHelper>().SingleInstance();
    }
}
