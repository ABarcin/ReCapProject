using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entitites.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            RentACarManager rentACarManager = new RentACarManager(new EfCarDal());
            //GetAllCars(rentACarManager);
            //AddCar(rentACarManager);
            //DeleteCar(rentACarManager);
            //UpdateCar(rentACarManager);
            GetAllCarsDetail(rentACarManager);

        }

        private static void GetAllCarsDetail(RentACarManager rentACarManager)
        {
            foreach (var car in rentACarManager.GetCarDetails())
            {
                Console.WriteLine(car.BrandName + " : " + car.CarName + " - " + car.ColorName + " Color" + " = " + car.DailyPrice + " Liras For a Day");
            }
        }

        private static void UpdateCar(RentACarManager rentACarManager)
        {
            foreach (var car in rentACarManager.GetAll())
            {
                if (car.CarId == 2006)
                {
                    var updatedCar = car;
                    updatedCar.CarName = "Volvo s60";
                    rentACarManager.Update(updatedCar);
                }
            }
        }

        private static void DeleteCar(RentACarManager rentACarManager)
        {
            foreach (var car in rentACarManager.GetAll())
            {
                if (car.CarId == 2006)
                {
                    rentACarManager.Delete(car);
                }
            }
        }

        private static void AddCar(RentACarManager rentACarManager)
        {
            Car car2 = new Car { BrandId = 22, CarName = "Accent-Era", ColorId = 4, DailyPrice = 90, ModelYear = 2010, Description = "Min Money", Rentable = false };
            rentACarManager.Add(car2);
            Console.WriteLine("After Added Database");
            foreach (var car in rentACarManager.GetAll())
            {
                Console.WriteLine(car.CarName + ": DailyPrice= " + car.DailyPrice);
            }
        }

        private static void GetAllCars(RentACarManager rentACarManager)
        {
            Console.WriteLine("All Cars List");
            foreach (var car in rentACarManager.GetAll())
            {
                Console.WriteLine(car.CarName + ": DailyPrice= " + car.DailyPrice);
            }
        }
    }
}
