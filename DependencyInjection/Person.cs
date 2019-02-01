using System;

namespace DependencyInjection
{
    public interface IPerson
    {

    }
    class Person:IPerson
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        public IAddress Address { get; set; }
        public Person(IAddress address)
        {
            Address = address;
        }

    }
}
