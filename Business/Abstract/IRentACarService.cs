using Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentACarService
    {
        List<Car> GetAll();
        List<Car> GetCarsByBrandId(int id);
        List<Car> GetCarsByColorId(int id);
        List<Car> GetByDailyPrice(decimal min, decimal max);
        Car GetById(int id);
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);

    }
}
