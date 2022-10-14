using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.Description).NotEmpty();
            RuleFor(c => c.Description).MinimumLength(2);
            RuleFor(c => c.ModelYear).GreaterThanOrEqualTo(1900);
            RuleFor(c => c.ModelYear).GreaterThanOrEqualTo(2000).When(c => c.BrandId == 3);
            RuleFor(c => c.Description).Must(StartWithv).WithMessage("Açıklamalar v harfi ile başlamalı");
        }

        private bool StartWithv(string arg)
        {
            return arg.StartsWith("v");
        }
    }
}
