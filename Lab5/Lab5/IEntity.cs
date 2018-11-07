using System.Collections.Generic;

namespace Lab5Proj
{
    public interface IEntity
    {
        int Id { set; get; }
        void Create(City city);
        void Add(POI poi);
        void Delete();
        List<IEntity> Load();
    }
}