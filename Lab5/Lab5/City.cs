using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Lab5Proj
{
    public class City:IEntity
    {
        public Guid Id { get; private set; }

        [StringLength(150, MinimumLength = 50)]
        public String Name { get; private set; }

        public String Description { get; private set; }

        public Double Latitude { get; private set; }

        public Double Longitude { get; private set; }

        public List<POI> POIs { get; private set; }
        int IEntity.Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Add(POI poi)
        {
            throw new NotImplementedException();
        }

        public void Create(City city)
        {

            ApplicationContext applicationContext = new ApplicationContext();
            applicationContext.Cities.Add(city);
            applicationContext.SaveChanges();
        }

        public void Delete(City city)
        {
            ApplicationContext applicationContext = new ApplicationContext();
            applicationContext.Cities.Remove(city);
            applicationContext.SaveChanges();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public List<IEntity> Load()
        {
            throw new NotImplementedException();
        }
    }
}