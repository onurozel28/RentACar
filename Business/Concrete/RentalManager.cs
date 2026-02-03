using Business.Abstract;
using Business.Constants;
using Core.Utilites.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RentalManager : IRentalService  
    {
        private IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {
            _rentalDal.Add(rental);
            return new SuccessResult(Messages.RentalAdded);
        }

        public IResult CheckReturnDate(int carId)
        {
            var result=_rentalDal.GetAll(r => r.CarId == carId && r.ReturnDate == null);
            if(result!=null)
            {
                return new ErrorResult(Messages.CheckReturnDate);
            }
            else
            {
                return new SuccessResult(Messages.CarAvailable);
            }
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.RentalDeleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IDataResult<List<RentalDetailDto>> GetRentalDetailDtos(int carId)
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetRentalDetails().Where(r => r.CarId == carId).ToList()); //kiralama detaylarını filtrele diyoruz.
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.RentalUpdated);
        }

        public IResult UpdateReturnDate(int carId)
        {
            var rental = _rentalDal.GetAll(r => r.CarId == carId && r.ReturnDate == null).FirstOrDefault(); //firstordefault kullanma sebebimiz şöyle: eğer kiralama yoksa null dönecek ve hata vermeyecek.

            if (rental == null)
            {
                // aktif kiralama yok → şimdilik bir şey yapmıyoruz
                return new SuccessResult("Aktif kiralama bulunamamaktadır!");
            }

            rental.ReturnDate = DateTime.Now;
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.RentalUpdated);
        }

    }
}


