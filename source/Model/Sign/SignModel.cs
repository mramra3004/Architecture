using Architecture.CrossCutting.Enums;

namespace Architecture.Model.Sign
{
    public class SignModel
    {
        public SignModel
        (
            long id,
            string login,
            string password,
            string salt,
            Roles roles
        )
        {
            UserId = id;
            Login = login;
            Password = password;
            Salt = salt;
            Roles = roles;
        }

        public long UserId { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public string Salt { get; set; }

        public Roles Roles { get; set; }
    }
}
