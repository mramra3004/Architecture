using Architecture.Model.UserLog;
using DotNetCore.Results;
using System.Threading.Tasks;

namespace Architecture.Application.UserLog
{
    public interface IUserLogApplicationService
    {
        Task<IResult> AddAsync(UserLogModel userLogModel);
    }
}
