using Core.Utilites.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<CarDetailDto>> Getall();
        IDataResult<CarDetailDto> GetById(int carId);
        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);
        IDataResult<List<CarDetailDto>> GetAllByBrandId(int Id); //şu markaya ait araçları getir
        IDataResult<List<Car>> GetByUnitPrice(decimal min, decimal max); //fiyat aralığına göre araçları getir. //Şimdilik double tutuyorum.ileride decimal yapabilirim.
        IDataResult<List<CarDetailDto>> GetCarDetails(int carId); //detaylı araç bilgilerini getir
        IDataResult<List<CarDetailDto>> GetAllbyColorId(int id); //renge göre detaylı araç bilgilerini getir

        IResult AddTransactionalTest(Car car);


    }
}
