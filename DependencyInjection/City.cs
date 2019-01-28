namespace DependencyInjection
{
    public class City
    {
        public string Name { get; set; }
        public Country Country { get; set; }
        public City(Country country)
        {
            Country = country;
        }
    }
}
