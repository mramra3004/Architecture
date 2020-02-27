using Architecture.Database.Database;
using Architecture.Domain;
using DotNetCore.EntityFrameworkCore;

namespace Architecture.Database.UserLog
{
    public sealed class UserLogRepository : EntityFrameworkCoreRepository<UserLogEntity>, IUserLogRepository
    {
        public UserLogRepository(Context context) : base(context)
        {
        }
    }
}
