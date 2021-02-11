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
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            UserManager userManager = new UserManager(new EfUserDal());

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
            Console.WriteLine("----------");

            Console.WriteLine("Kullanıcı Listesi");
            foreach (var user in userManager.GetAll().Data)
            {
                Console.WriteLine(user.Id + " - " + user.FirstName + " " + user.LastName);
                Console.WriteLine(user.Email + " " + user.Password);
            }
            Console.WriteLine("----------");

            Console.WriteLine("Müşteri Listesi");
            foreach (var customer in customerManager.GetAll().Data)
            {
                Console.WriteLine(customer.Id + " " + customer.CompanyName + " " + userManager.GetById(customer.UserId).Data.FirstName );
            }
            Console.WriteLine("----------");

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
