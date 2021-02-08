using Business.Abstract;
using DataAccess.Abstract;
using Entitites.Concrete;
using Entitites.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentACarManager : IRentACarService
    {
        ICarDal _carDal;
        public RentACarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public void Add(Car car)
        {
            if (car.CarName.Length > 1 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
            }
            else
            {
                if (car.CarName.Length <= 1)
                {
                    Console.WriteLine("The car wasn't added to database.*** Car name must be greater than 1 character ");
                }else if (car.DailyPrice <= 0)
                {
                    Console.WriteLine("The car wasn't added to database.***Car daily price must be greater than 0 Lira");
                }
            }
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(p => p.BrandId == id);
        }
        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(p => p.ColorId == id);
        }
        

        public List<Car> GetByDailyPrice(decimal min, decimal max)
        {
            return _carDal.GetAll(p => p.DailyPrice >= min && p.DailyPrice <= max);
        }

        public Car GetById(int id)
        {
            return _carDal.Get(p=>p.CarId==id);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }
    }
}
