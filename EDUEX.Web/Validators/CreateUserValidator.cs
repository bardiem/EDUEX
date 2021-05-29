using EDUEX.BL;
using EDUEX.Web.Dto.UserDtos;
using FluentValidation;

namespace EDUEX.Web.Validators
{
    public class CreateUserValidator : BaseValidator<CreateUserDto>
    {
        private readonly IUserAuthBL _userAuthBL;
        public CreateUserValidator(IUserAuthBL userAuthBL)
        {
            _userAuthBL = userAuthBL;

            RuleFor(u => u.FirstName)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("First name is required")
                .MinimumLength(2).WithMessage("First name should have at least 2 chars");

            RuleFor(u => u.LastName)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Last name is required")
                .MinimumLength(2).WithMessage("Last name should have at least 2 chars");

            RuleFor(u => u.Position)
                .Cascade(CascadeMode.Stop)
                .MinimumLength(5).WithMessage("Position should have at least 5 chars");

            RuleFor(u => u.BirthDate)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Birth date is required")
                .Must(IsValidBirthDate).WithMessage("Birth date is incorrect");

            RuleFor(u => u.Email)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Email is required")
                .EmailAddress().WithMessage("Email is incorrect")
                .Must(UniqueEmail).WithMessage("Email already exists");

            RuleFor(u => u.Password)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Password is required")
                .MinimumLength(5).WithMessage("Password should be at least 5 characters");

            RuleFor(u => u.ConfirmPassword)
                .Equal(u => u.Password).WithMessage("Passwords should be same");
            
        }

        private bool UniqueEmail(string email)
        {
            var user = _userAuthBL.GetByEmail(email);
            return user == null;
        }

    }
}
