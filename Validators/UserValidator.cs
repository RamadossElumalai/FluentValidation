using FluentValidation;
using FluentValidationDemo.Models;

namespace FluentValidationDemo.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            // we can use validator like this below, in case of if your having limited validation
            // without having large validation
            #region
            //RuleFor(u => u.Name).NotNull().NotEmpty().WithMessage("Name is required");
            //RuleFor(u => u.Email).NotNull().NotEmpty().WithMessage("Email is required")
            //    .EmailAddress().WithMessage("Please provide valid email address");
            //RuleFor(u => u.Address).NotNull().NotEmpty().WithMessage("Address is required")
            //    .MaximumLength(10).WithMessage("Address charecter lenght should not be more then 10 Charecters");
            //RuleFor(u => u.Address)
            //    .Must(a => a?.ToLower().Contains("street") == true)
            //    .WithMessage("Address must contain street");
            //RuleForEach(u => u.MemberShips)
            //    .SetValidator(new MemeberShipValidator());
            #endregion

            // In case if your having large validation, we can spilit it and we can use like below
            Include(new SimpleValidator());
            Include(new ComplexValidator());
        }
    }

    public class SimpleValidator : AbstractValidator<User>
    {
        public SimpleValidator()
        {
            RuleFor(u => u.Name).NotNull().NotEmpty().WithMessage("Name is required");
            RuleFor(u => u.Email).NotNull().NotEmpty().WithMessage("Email is required")
                .EmailAddress().WithMessage("Please provide valid email address");
        }
    }

    public class ComplexValidator : AbstractValidator<User>
    {
        public ComplexValidator()
        {
            RuleFor(u => u.Address).NotNull().NotEmpty().WithMessage("Address is required")
                .MaximumLength(10).WithMessage("Address charecter lenght should not be more then 10 Charecters");
            RuleFor(u => u.Address)
                .Must(a => a?.ToLower().Contains("street") == true)
                .WithMessage("Address must contain street");
            RuleForEach(u => u.MemberShips)
                .SetValidator(new MemeberShipValidator());
        }
    }

    public class MemeberShipValidator : AbstractValidator<MemeberShip>
    {
        public MemeberShipValidator()
        {
            RuleFor(x => x.Name).NotEmpty().NotNull().WithMessage("Name is required");
        }
    }
}
