using Architecture.CrossCutting.Enums;

namespace Architecture.Model.Sign
{
    public class SignedInModel
    {
        public long UserId { get; set; }

        public Roles Roles { get; set; }
    }
}
