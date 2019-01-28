using System;

namespace DependencyInjection
{

    class Person
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        public Address Address { get; set; }
        public Person(IAddress address)
        {
          //  Address = address ?? throw new ArgumentNullException(nameof(address));
        }

    }
}
