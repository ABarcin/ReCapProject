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
            CarManager carManager = new CarManager(new EfCarDal());
            //GetAllCars(carManager);
            //AddCar(carManager);
            //DeleteCar(carManager);
            //UpdateCar(carManager);
            //GetAllCarsDetail(carManager);

        }

        private static void GetAllCarsDetail(CarManager carManager)
        {
            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine(car.BrandName + " : " + car.CarName + " - " + car.ColorName + " Color" + " = " + car.DailyPrice + " Liras For a Day");
            }
        }

        private static void UpdateCar(CarManager carManager)
        {
            foreach (var car in carManager.GetAll().Data)
            {
                if (car.CarId == 2006)
                {
                    var updatedCar = car;
                    updatedCar.CarName = "Volvo s60";
                    carManager.Update(updatedCar);
                }
            }
        }

        private static void DeleteCar(CarManager carManager)
        {
            foreach (var car in carManager.GetAll().Data)
            {
                if (car.CarId == 2006)
                {
                    carManager.Delete(car);
                }
            }
        }

        private static void AddCar(CarManager carManager)
        {
            Car car2 = new Car { BrandId = 22, CarName = "Accent-Era", ColorId = 4, DailyPrice = 90, ModelYear = 2010, Description = "Min Money", Rentable = false };
            carManager.Add(car2);
            Console.WriteLine("After Added Database");
            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine(car.CarName + ": DailyPrice= " + car.DailyPrice);
            }
        }

        private static void GetAllCars(CarManager carManager)
        {
            Console.WriteLine("All Cars List");
            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine(car.CarName + ": DailyPrice= " + car.DailyPrice);
            }
        }
    }
}
