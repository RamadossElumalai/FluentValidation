using FluentValidation;
using FluentValidationDemo.Models;

namespace FluentValidationDemo.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.Name).NotNull().NotEmpty().WithMessage("Name is required");
            RuleFor(u => u.Email).EmailAddress();
            RuleFor(u => u.Address).NotNull().MaximumLength(10);
            RuleFor(u => u.Address).Must(a => a?.ToLower().Contains("street") == true);
        }
    }
}
