using Core.Utilites.Results;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<List<Rental>> GetAll();
        IDataResult<List<RentalDetailDto>> GetRentalDetailDtos(int carId); //bir araca ait kiralama detaylarını getir
        IResult Add(Rental rental);
        IResult Delete(Rental rental);

        IResult Update(Rental rental);
        IResult CheckReturnDate(int carId); //aracın teslim edilip edilmediğini kontrol et
        IResult UpdateReturnDate(int carId); //aracın teslim tarihini güncelle
        
    }
}
