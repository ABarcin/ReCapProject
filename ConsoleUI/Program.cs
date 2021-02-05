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
            Console.WriteLine("All Cars List");
            foreach (var car in rentACarManager.GetAll())
            {
                Console.WriteLine(car.CarName +": DailyPrice= "+car.DailyPrice);
            }
            Console.WriteLine();
            Console.WriteLine("After Fault Added");
            Car car1 = new Car {  BrandId = 3, CarName = "V", ColorId = 4, DailyPrice = 600, ModelYear = 2019, Description = "The Best Car For Everything",Rentable=false };
            rentACarManager.Add(car1);
            Console.WriteLine();

            Console.WriteLine();
            Car car2 = new Car {  BrandId = 22, CarName = "Accent-Era", ColorId = 4, DailyPrice = 90, ModelYear = 2010, Description = "Min Money", Rentable = false };
            rentACarManager.Add(car2);
            Console.WriteLine();
            Console.WriteLine("After Added Database");
            foreach (var car in rentACarManager.GetAll())
            {
                Console.WriteLine(car.CarName + ": DailyPrice= " + car.DailyPrice);
            }

        }
    }
}
