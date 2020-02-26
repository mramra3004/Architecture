using Architecture.CrossCutting;
using Architecture.Domain;
using Architecture.Model;
using DotNetCore.EntityFrameworkCore;
using DotNetCore.Mapping;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Architecture.Database
{
    public sealed class UserRepository : EntityFrameworkCoreRepository<UserEntity>, IUserRepository
    {
        public UserRepository(Context context) : base(context) { }

        public Task<UserModel> GetByIdAsync(long id)
        {
            return Queryable
                .Where(userEntity => userEntity.Id == id)
                .Project<UserEntity, UserModel>()
                .FirstOrDefaultAsync();
        }

        public Task<SignModel> SignInAsync(SignInModel signInModel)
        {
            return Queryable
                .Where
                (
                    userEntity =>
                    userEntity.Sign.Login == signInModel.Login &&
                    userEntity.Status == Status.Active
                )
                .Select
                (
                    userEntity =>
                    new SignModel
                    (
                        userEntity.Id,
                        userEntity.Sign.Login,
                        userEntity.Sign.Password,
                        userEntity.Sign.Salt,
                        userEntity.Sign.Roles
                    )
                )
                .SingleOrDefaultAsync();
        }

        public Task UpdateStatusAsync(UserEntity userEntity)
        {
            return UpdatePartialAsync(userEntity.Id, new { userEntity.Status });
        }
    }
}
