using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<Car> GetByCarId(int id);
        IDataResult<List<Car>> GetAllByBrandId(int id);
        IDataResult<List<Car>> GetAllByColorId(int id);
        IDataResult<List<Car>> GetAllByModelYear(int min, int max);
        IDataResult<List<CarDetailDto>> GetAllCarDetails();
        IResult Add(Car car); //void oldugu için IResult değer döndürenlerde IDataResult
        IResult Delete(Car car);
        IResult DeleteByCarId(int carId);
        IResult Update(Car car);
        IResult AddTransactionalTest(Car car);
    }
}
