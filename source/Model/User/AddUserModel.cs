using Architecture.Model.Sign;

namespace Architecture.Model.User
{
    public class AddUserModel : UserModel
    {
        public SignInModel SignIn { get; set; }
    }
}
