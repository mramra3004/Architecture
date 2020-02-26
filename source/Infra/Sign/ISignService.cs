using Architecture.Model;
using DotNetCore.Results;

namespace Architecture.Infra
{
    public interface ISignService
    {
        SignModel CreateSign(SignInModel signInModel);

        TokenModel CreateToken(SignModel signModel);

        IResult Validate(SignModel signModel, SignInModel signInModel);
    }
}
