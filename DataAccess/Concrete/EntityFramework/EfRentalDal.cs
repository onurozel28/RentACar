using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentACarContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using(RentACarContext rentACarContext=new RentACarContext())
            {
                var result = from r in rentACarContext.Rentals
                             join c in rentACarContext.Cars
                             on r.CarId equals c.CarId
                             join b in rentACarContext.Brands
                             on c.BrandId equals b.BrandId
                             join cu in rentACarContext.Customers
                             on r.CustomerId equals cu.CustomerId
                             
                             
                             select new RentalDetailDto
                             {

                                 Id = r.Id,
                                 CarName = c.CarName,
                                 CarId = c.CarId,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate,
                             };
                return result.ToList();
            }
        }
    }
}
