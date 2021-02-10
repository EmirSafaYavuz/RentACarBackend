using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());

            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.Id + " - " + color.Name);
            }
            
            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.ModelYear + " " + " " + car.Description + " " + car.DailyPrice + " TL");
            //}
            //foreach (var car in carManager.GetCarDetails())
            //{

            //    Console.WriteLine(car.BrandName + " " + car.ColorName + " " + car.ModelYear + " " + car.Description);
            //}
        }
    }
}
