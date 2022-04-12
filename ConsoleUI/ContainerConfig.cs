using Autofac;
using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    /*Container es el lugar donde se define todas las clases que 
     * queremos instanciar*/
    public static class ContainerConfig
    {
       public static IContainer Configure()
        {
            var builder = new ContainerBuilder(); // registro de dependencias
            builder.RegisterType<Application>().As<IApplication>(); // Dependenci inversion principle
            builder.RegisterType<BusinessLogic>().As<IBusinessLogic>();// hacer esto clase por clase puede ser tedioso
                                                                       //Cuando se solicite la interfaz pasa la capa logica
                                                                       //Automatizacion del proceso
            //builder.RegisterType<BetterBusinessLogic>().As < IBusinessLogic >
           builder.RegisterAssemblyTypes(Assembly.Load(nameof(DemoLibrary)))
                .Where(t => t.Namespace.Contains("Utilities"))
                .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name));


            return builder.Build();
            
        }
    }
}
