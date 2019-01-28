using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Modules;

namespace DependencyInjection
{

    class Temp:NinjectModule
    {
        public override void Load()
        {
            Bind<IAddress>().To<Address>();

        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            IKernel kernel= new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            var temp = kernel.Get<IAddress>();
            
            Person person = new Person(temp);


            
            Console.ReadKey();

        }
    }
}
