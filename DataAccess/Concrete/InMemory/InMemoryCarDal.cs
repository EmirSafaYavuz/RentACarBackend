using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;
using Entities.DTOs;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _carList;

        public InMemoryCarDal()
        {
            //Brand Id: 1=Mercedes, 2=BMW, 3=Volkswagen
            //Color Id: 1=Siyah, 2=Beyaz
            _carList = new List<Car> {
                new Car() {Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 1000, ModelYear = 2018, Description = "E250 2018"},
                new Car() {Id = 2, BrandId = 2, ColorId = 2, DailyPrice = 800, ModelYear = 2016, Description = "520d 2016"},
                new Car() {Id = 3, BrandId = 3, ColorId = 1, DailyPrice = 400, ModelYear = 2013, Description = "Polo 2013"} 
            };
        } 

        public void Add(Car car)
        {
            _carList.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _carList.SingleOrDefault(c => c.Id == car.Id);
            _carList.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _carList;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int id)
        {
            return _carList.Where(ctb => ctb.Id == id).ToList();

        }

        public List<CarDetailDto> GetCarDetails(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _carList.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
        }
    }

        
    }
