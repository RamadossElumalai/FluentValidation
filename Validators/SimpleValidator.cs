using FluentValidation;
using FluentValidationDemo.Models;

namespace FluentValidationDemo.Validators
{
    public class SimpleValidator : AbstractValidator<User>
    {
        public SimpleValidator()
        {
            RuleFor(u => u.Name).NotNull().NotEmpty().WithMessage("Name is required");
            RuleFor(u => u.Email).NotNull().NotEmpty().WithMessage("Email is required")
                .EmailAddress().WithMessage("Please provide valid email address");
        }
    }
}
