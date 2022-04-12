using Autofac;
using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //BusinessLogic businessLogic = new BusinessLogic();
            //businessLogic.ProcessData();

            // save container
            var container=ContainerConfig.Configure();

            using(var scope=container.BeginLifetimeScope())
            {
                var app=scope.Resolve<IApplication>();
                app.Run();
            } //set new scope for the instances begin passed out razon multiple instances 


            Console.ReadLine();
        }
    }
}
