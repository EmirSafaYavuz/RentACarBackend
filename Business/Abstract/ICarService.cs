using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);
        IDataResult<List<Car>> GetAll();
        IDataResult<Car> GetById(int id);
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IDataResult<List<CarDetailDto>> GetCarDetailsById(int id);
        IDataResult<List<CarDetailDto>> GetAllByColorId(int id);
        IDataResult<List<CarDetailDto>> GetAllByBrandId(int id);
        IDataResult<List<Car>> GetByDailyPrice(decimal min, decimal max);
        IDataResult<List<Car>> GetByModelYear(string year);

    }
}
