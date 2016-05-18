using Castle.Windsor;
using Castle.Windsor.Installer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteWindsor
{
   public static class ContainerWindsor
    {
       public static IWindsorContainer Container { get {
           var container = new WindsorContainer();
           container.Install(FromAssembly.This());
           return container;
       } }
    }
}
