using DataLayer.Data;
using System.Collections.Generic;

namespace Laborator.Business
{
    public interface IRepository
    {
        void Create(City city);
        void Edit(City city);
        void Delete(City city);
        List<City> GetCity();
    }
}
