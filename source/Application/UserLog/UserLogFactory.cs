using Architecture.CrossCutting.Enums;
using Architecture.Domain;
using Architecture.Model.Sign;
using Architecture.Model.UserLog;

namespace Architecture.Application.UserLog
{
    public static class UserLogFactory
    {
        public static UserLogEntity Create(UserLogModel userLogModel)
        {
            return new UserLogEntity(userLogModel.UserId, userLogModel.LogType);
        }

        public static UserLogModel Create(SignModel signModel)
        {
            return new UserLogModel(signModel.UserId, LogType.SignIn);
        }

        public static UserLogModel Create(SignedInModel signedInModel)
        {
            return new UserLogModel(signedInModel.UserId, LogType.SignOut);
        }
    }
}
