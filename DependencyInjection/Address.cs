using System;

namespace DependencyInjection
{
    public interface IAddress
    {
        void Show();
        void Set(string street);

    }

    public class Address:IAddress
    {
        public string Street { get; set; }
        public ICity City { get; set; }
        public Address(ICity city)
        {
            City = city;
        }
        public void Set(string street)
        {
            Street = street;
        }
        public void Show()
        {
            Console.WriteLine(Street);
        }
    }
}
