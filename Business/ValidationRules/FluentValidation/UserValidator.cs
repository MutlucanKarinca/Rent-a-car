using System.Data;
using Castle.DynamicProxy.Generators.Emitters.SimpleAST;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using FluentValidation;


namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator:AbstractValidator<User>
    {
        IUserDal userDal = new EfUserDal();
        public UserValidator()
        {
            RuleFor(u => u.Email).EmailAddress();
            RuleFor(u => u.FirstName).NotEmpty();
            RuleFor(u => u.LastName).NotEmpty();
            //RuleFor(u => u.Password).MinimumLength(8);
            RuleFor(u => u.Email).Must(uniqueEmail).WithMessage("Kayıt olduğunuz email zaten sistemde kayıtlı");

        }

        private bool uniqueEmail(string arg)
        {
            var result = userDal.GetAll();
            var email = result.Find(e => e.Email == arg);
            if (email == null) return true;
            else return false;

            
        }
    }
}