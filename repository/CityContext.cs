namespace plants_dotnet.repository
{
    public class CityContext : DBContext
    {
        public CityContext() : base()
        {

        }
        public DbSet<City> City {get; set;}
    }
}
