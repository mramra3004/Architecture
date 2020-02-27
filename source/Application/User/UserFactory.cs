using Architecture.Domain;
using Architecture.Domain.ValueObjects;
using Architecture.Model.Sign;
using Architecture.Model.User;

namespace Architecture.Application.User
{
    public static class UserFactory
    {
        public static UserEntity Create(long id)
        {
            return new UserEntity(id);
        }

        public static UserEntity Create(AddUserModel addUserModel, SignModel signModel)
        {
            return new UserEntity
            (
                addUserModel.Id,
                new FullName
                (
                    addUserModel.FullName.Name,
                    addUserModel.FullName.Surname
                ),
                new Email(addUserModel.Email),
                new Sign
                (
                    signModel.Login,
                    signModel.Password,
                    signModel.Salt,
                    signModel.Roles
                ),
                default
            );
        }
    }
}
