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
            Console.WriteLine("Merhaba!");
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());

            Console.WriteLine("Renk Listesi");
            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine(color.Id + " - " + color.Name);
            }
            Console.WriteLine("----------");

            Console.WriteLine("Marka Listesi");
            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.Id + " - " + brand.Name);
            }
            Console.WriteLine("----------");

            Console.WriteLine("Araç Listesi");
            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine(car.Id + " - " + car.Description + " - " + car.ModelYear);
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
