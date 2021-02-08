using DataAccess.Abstract;
using Entitites.Concrete;
using Entitites.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1,BrandId=1,CarName="Q7",ColorId=1,DailyPrice=500,ModelYear=2017,Description="The best car for comfort"},
                new Car{CarId=2,BrandId=2,CarName="Şahin",ColorId=3,DailyPrice=100,ModelYear=2000,Description="The best car for min price"},
                new Car{CarId=3,BrandId=3,CarName="S40",ColorId=1,DailyPrice=400,ModelYear=2016,Description="The best car for confidence"},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            _cars.Remove(_cars.SingleOrDefault(p => p.CarId == car.CarId));
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car GetById(int id)
        {
            return _cars.SingleOrDefault(p => p.CarId == id);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUptaded = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            carToUptaded.BrandId = car.BrandId;
            carToUptaded.CarName = car.CarName;
            carToUptaded.ColorId = car.ColorId;
            carToUptaded.DailyPrice = car.DailyPrice;
            carToUptaded.ModelYear = car.ModelYear;
            carToUptaded.Description = car.Description;
        }
    }
}
