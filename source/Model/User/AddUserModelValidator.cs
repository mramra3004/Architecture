using FluentValidation;

namespace Architecture.Model.User
{
    public sealed class AddUserModelValidator : UserModelValidator<AddUserModel>
    {
        public AddUserModelValidator()
        {
            RuleFor(x => x.SignIn).NotEmpty();
            RuleFor(x => x.SignIn.Login).NotEmpty();
            RuleFor(x => x.SignIn.Password).NotEmpty();
        }
    }
}
