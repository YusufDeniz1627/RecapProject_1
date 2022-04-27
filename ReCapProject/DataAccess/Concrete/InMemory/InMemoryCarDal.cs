using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car { Id = 1, BrandId = 1, ColorId = 1, ModelYear = 2015, DailyPrice = 150, Descriptiom = "Volvo Xc90" },
                new Car { Id = 2, BrandId = 1, ColorId = 1, ModelYear = 2016, DailyPrice = 1500, Descriptiom = "Mercedes e200" },
                new Car { Id = 3, BrandId = 1, ColorId = 2, ModelYear = 2017, DailyPrice = 250, Descriptiom = "passat" },
                new Car { Id = 4, BrandId = 2, ColorId = 2, ModelYear = 2018, DailyPrice = 750, Descriptiom = "Bmw 320" },
                new Car { Id = 5, BrandId = 2, ColorId = 2, ModelYear = 2019, DailyPrice = 800, Descriptiom = "bmw 520" },
            };

        }


        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c =>c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllByBrandId(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public List<Car> GetAllByColorId(int colorId)
        {
            return _cars.Where(c => c.ColorId == colorId).ToList();
        }

        public void Update(Car car)
        {
            Car carUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carUpdate.BrandId = car.BrandId;
            carUpdate.ColorId = car.ColorId;
            carUpdate.DailyPrice = car.DailyPrice;
            carUpdate.Descriptiom = car.Descriptiom;
        }
    }
}
