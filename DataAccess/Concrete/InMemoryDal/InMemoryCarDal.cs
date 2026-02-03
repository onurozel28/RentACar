using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemoryDal
{
    public class InMemoryCarDal:ICarDal
    {
        private List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
          {
              new Car
              { BrandId=1,ColorId=1,DailyPrice=187000,Description = "Siyah,Vites:Otomatik,dört çeker araba.",CarId=1 },
              new Car 
              {BrandId = 1, ColorId = 2, DailyPrice = 195000, Description = "Beyaz,Vites:Otomatik,dört çeker araba.",CarId = 2 },
              new Car
                {
                    BrandId = 2, ColorId = 3, DailyPrice = 225000, Description = "Mavi,Vites:Manuel,dört çeker araba.",
                    CarId = 3
                },
                new Car
                {
                    BrandId = 2, ColorId = 1, DailyPrice = 113000, Description = "Siyah,Vites:Manuel,dört çeker araba.",
                    CarId = 4,
                },
                new Car
                {
                    BrandId = 3, ColorId = 3, DailyPrice = 147000, Description = "Mavi,Vites:Otomatik,dört çeker araba.",
                    CarId = 5
                }
          };
        }

        public void Add(Car entity)
        {
            _cars.Add(entity);
        }

        public void Delete(Car entity)
        {
            Car cardelete=_cars.FirstOrDefault(c=>c.CarId==entity.CarId);
            _cars.Remove(cardelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            return _cars.SingleOrDefault(filter.Compile());
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _cars;
        }

        public void Update(Car entity)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == entity.CarId);
            carToUpdate.ColorId = entity.ColorId;
            carToUpdate.BrandId = entity.BrandId;
            carToUpdate.DailyPrice = entity.DailyPrice;
            carToUpdate.Description = entity.Description;
            carToUpdate.ModelYear = entity.ModelYear;
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }
    }
}
