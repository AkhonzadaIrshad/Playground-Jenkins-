namespace DependencyInjection
{
    public class IAddress
    {
        
    }

    public class Address:IAddress
    {
        public string Street { get; set; }
        public City City { get; set; }
        public Address(City city)
        {
            City = city;
        }
    }
}
