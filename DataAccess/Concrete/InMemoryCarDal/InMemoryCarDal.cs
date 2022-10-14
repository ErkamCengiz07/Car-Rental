using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemoryCarDal
{
    public class InMemoryCarDal : ICarDal
    {
        private List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
            new Car { CarId = 1, BrandId = 1, ColorId = 1, DailyPrice = 1500, Description = "Mazda", ModelYear = 2022 },
            new Car { CarId = 2, BrandId = 1, ColorId = 2, DailyPrice = 1500, Description = "Bmw", ModelYear = 2010 },
            new Car { CarId = 3, BrandId = 2, ColorId = 2, DailyPrice = 1500, Description = "Audi", ModelYear = 2001 },
            new Car { CarId = 4, BrandId = 2, ColorId = 1, DailyPrice = 1500, Description = "Mercedes", ModelYear = 2005 },
            new Car { CarId = 5, BrandId = 1, ColorId = 1, DailyPrice = 1500, Description = "Polo", ModelYear = 2000 }
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _cars;
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
