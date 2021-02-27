using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CarImageValidator:AbstractValidator<CarImage>
    {
        public CarImageValidator()
        {
            //RuleFor(c => c.ImagePath)
            //    .Must(x => x.EndsWith(".jpeg") || x.EndsWith(".jpg") || x.EndsWith(".png"))
            //    .WithMessage("Sadece .jpeg, .jpg, .png uzantılı dosyalar yüklenebilir");
            RuleFor(c => c.CarId).NotEmpty();
        }
    }
}