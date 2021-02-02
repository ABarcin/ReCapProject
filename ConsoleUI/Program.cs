using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entitites.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            RentACarManager rentACarManager = new RentACarManager(new InMemoryCarDal());
            Console.WriteLine("All Cars List");
            foreach (var car in rentACarManager.GetAll())
            {
                Console.WriteLine(car.CarName +": DailyPrice= "+car.DailyPrice);
            }
            Console.WriteLine();

            Car car1=new Car { CarId=6,BrandId=3,CarName="V40",ColorId=4,DailyPrice=600,ModelYear=2019,Description="The Best Car For Everything"};
            rentACarManager.Add(car1);
            Console.WriteLine("All List After Added A New Car ");
            foreach (var car in rentACarManager.GetAll())
            {
                Console.WriteLine(car.CarName + ": DailyPrice= " + car.DailyPrice);
            }
            Console.WriteLine();
            rentACarManager.Delete(car1);
            Console.WriteLine("All List After Deleted A Car ");

            foreach (var car in rentACarManager.GetAll())
            {
                Console.WriteLine(car.CarName + ": DailyPrice= " + car.DailyPrice);
            }
            Console.WriteLine();
            Console.WriteLine("All List After Updated A Car");
            Car car3 = new Car { CarId = 2, BrandId = 5, CarName = "C180", ColorId = 3, DailyPrice = 1000, ModelYear = 2020, Description = "İt is Mercedes" };

            rentACarManager.Update(car3);
            foreach (var car in rentACarManager.GetAll())
            {
                Console.WriteLine(car.CarName + ": DailyPrice= " + car.DailyPrice);
            }

            Console.WriteLine();
            Console.WriteLine("GetById=3 ");

            Console.WriteLine((rentACarManager.GetById(1)).CarName);
        }
    }
}
