namespace Lab5Proj
{
    class POIRepository
    {
        ApplicationContext _applicationContext;

        public POIRepository(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }

        public void Add(POI poi)
        {
            _applicationContext.POIs.Add(poi);
            _applicationContext.SaveChanges();
        }

        public void Delete(POI poi)
        {
            _applicationContext.POIs.Remove(poi);
            _applicationContext.SaveChanges();
        }

    }
}
