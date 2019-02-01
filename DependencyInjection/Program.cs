using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Extensions.Conventions;
using Ninject.Modules;

namespace DependencyInjection
{

    class SomeOtherClass : IAddress
    {
      
        public void Show()
        {
            throw new NotImplementedException();
        }

        public void Set(string street)
        {
            throw new NotImplementedException();
        }
    }

    public class Program
    {
        static void RegisterServices(IKernel kernel)
        {
            kernel.Bind(x =>
                {
                    x.FromThisAssembly()
                        .SelectAllClasses()
                        .BindDefaultInterface();
                }
            );

        }
        static void Main(string[] args)
        {

            IKernel kernel = new StandardKernel();
            RegisterServices(kernel);
            var temp = kernel.Get<IAddress>();
            var person = new Person(temp);
            person.Address.Set("Lahore");
            person.Address.Show();

            Console.ReadKey();

        }
    }
}
