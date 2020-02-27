using Architecture.Domain;
using DotNetCore.Repositories;

namespace Architecture.Database.UserLog
{
    public interface IUserLogRepository : IRepository<UserLogEntity>
    {
    }
}
