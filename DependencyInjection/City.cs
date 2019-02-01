namespace DependencyInjection
{
    public class City:ICity
    {
        public string Name { get; set; }
        public ICountry Country { get; set; }
        public City(ICountry country)
        {
            Country = country;
        }
    }

    public interface ICity
    {
    }
}
