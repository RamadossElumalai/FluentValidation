using FluentValidation;
using FluentValidationDemo.Models;

namespace FluentValidationDemo.Validators
{
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
}
