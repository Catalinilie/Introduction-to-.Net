namespace Lab5Proj
{
    class CityRepository
    {
        ApplicationContext _applicationContext;

        public CityRepository(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }

        public void Create(City city)
        {
            _applicationContext.Cities.Add(city);
            _applicationContext.SaveChanges();
        }

        public void Delete(City city)
        {
            _applicationContext.Cities.Remove(city);
            _applicationContext.SaveChanges();
        }
    }
}
