using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Lab5Proj
{
    public class POI:IEntity
    {
        public Guid Id { get; private set; }

        [StringLength(150, MinimumLength = 50)]
        public String Name { get; private set; }

        public String Description { get; private set; }

        public City Town { get; private set; }
        int IEntity.Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        
        public void Add(POI poi)
        {
            ApplicationContext applicationContext = new ApplicationContext();
            applicationContext.POIs.Add(poi);
            applicationContext.SaveChanges();
        }

        public void Create(City city)
        {
            ((IEntity)Town).Create(city);
        }

        public void Delete(POI poi)
        {
            ApplicationContext applicationContext = new ApplicationContext();
            applicationContext.POIs.Remove(poi);
            applicationContext.SaveChanges();
        }

        public void Delete()
        {
            ((IEntity)Town).Delete();
        }

        public List<IEntity> Load()
        {
            throw new NotImplementedException();
        }
    }
}
