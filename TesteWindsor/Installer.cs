using Castle.MicroKernel.Registration;
using ClassLibraryInterface;
using ClassLibraryWindsor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteWindsor
{
    public class Installer : IWindsorInstaller
    {

        public void Install(Castle.Windsor.IWindsorContainer container, Castle.MicroKernel.SubSystems.Configuration.IConfigurationStore store)
        {
           container.Register(Component.For<ICommon>().ImplementedBy<Common>());

        }
    }
}
