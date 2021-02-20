using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class RentalValidator:AbstractValidator<Rental>
    {

        IRentalDal userDal = new EfRentalDal();
        public RentalValidator()
        {
            RuleFor(r => r.CarId).NotEmpty();
            RuleFor(r => r.CarId).Must(availableCar).WithMessage("Araç zaten kiralanmış");
            RuleFor(r => r.CustomerId).NotEmpty();
            RuleFor(r => r.RentDate).NotEmpty();
            
        }
        private bool availableCar(int arg)
        {
            var result = userDal.GetAll();
            var rental = result.Find(e => e.CarId == arg);
            if (rental == null) return true;
            else return false;


        }
    }
}