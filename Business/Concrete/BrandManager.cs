using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Validation;
using Core.Utilites.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        private IBrandDal _brandDal; 

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
        [ValidationAspect(typeof(BrandValidator))]
        public IResult Add(Brand brand)
        {
           _brandDal.Add(brand);
            return new SuccessResult(Messages.BrandAdded);
        }

        public IResult Delete(Brand brand)
        {
            _brandDal.Delete(brand);
             return new SuccessResult(Messages.BrandDeleted);
        }
        [PerformanceAspect(5)]
        public IDataResult<List<Brand>> GetAll()
        {
            return new DataResult<List<Brand>>(_brandDal.GetAll(),true);
        }

        public IDataResult<Brand> GetById(int id)
        {
           return new SuccessDataResult<Brand>(_brandDal.Get(ı=>ı.BrandId==id));
        }

        public IResult Update(Brand brand)
        {
           _brandDal.Update(brand);
            return new SuccessResult(Messages.BrandUpdated);
        }
    }
}
