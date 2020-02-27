using Architecture.Domain;
using Architecture.Model.Sign;
using Architecture.Model.User;
using DotNetCore.Repositories;
using System.Threading.Tasks;

namespace Architecture.Database.User
{
    public interface IUserRepository : IRepository<UserEntity>
    {
        Task<UserModel> GetByIdAsync(long id);

        Task<SignModel> SignInAsync(SignInModel signInModel);

        Task UpdateStatusAsync(UserEntity userEntity);
    }
}
