using Architecture.Model.Sign;
using DotNetCore.Results;

namespace Architecture.Infra.Sign
{
    public interface ISignService
    {
        SignModel CreateSign(SignInModel signInModel);

        TokenModel CreateToken(SignModel signModel);

        IResult Validate(SignModel signModel, SignInModel signInModel);
    }
}
