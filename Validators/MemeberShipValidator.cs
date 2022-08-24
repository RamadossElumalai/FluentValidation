using FluentValidation;
using FluentValidationDemo.Models;

namespace FluentValidationDemo.Validators
{
    public class MemeberShipValidator : AbstractValidator<MemeberShip>
    {
        public MemeberShipValidator()
        {
            RuleFor(x => x.Name).NotEmpty().NotNull().WithMessage("Name is required");
        }
    }
}
