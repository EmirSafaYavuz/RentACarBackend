using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void Add(Brand brand)
        {
            if(brand.Name.Length > 2)
            {
                _brandDal.Add(brand);
                Console.WriteLine("Marka Eklendi!");
            }
            else
            {
                Console.WriteLine("Lütfen Marka İsmini 2 Karakterden Uzun Giriniz! | Girdiğiniz Marka İsmi: " + brand.Name);
            }
        }

        public void Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            Console.WriteLine("Marka Silindi!");
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public Brand GetById(int id)
        {
            return _brandDal.Get(c => c.Id == id);
        }

        public void Update(Brand brand)
        {
            if (brand.Name.Length > 2)
            {
                _brandDal.Update(brand);
                Console.WriteLine("Marka Güncellendi!");
            }
            else
            {
                Console.WriteLine("Lütfen Marka İsmini 2 Karakterden Uzun Giriniz! | Girdiğiniz Marka İsmi: " + brand.Name);
            }
        }
    }
}
