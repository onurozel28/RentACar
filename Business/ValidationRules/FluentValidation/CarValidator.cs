using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.CarName).NotEmpty();
            RuleFor(c => c.CarName).MaximumLength(3);
            RuleFor(c => c.CategoryId).NotEmpty().GreaterThan(0);
            RuleFor(c => c.BrandId).NotEmpty().GreaterThan(0);
            RuleFor(c => c.ColorId).NotEmpty().GreaterThan(0);
            
        }
    }
}
