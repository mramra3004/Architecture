using Architecture.CrossCutting;
using Architecture.CrossCutting.Enums;
using Architecture.Domain.ValueObjects;
using DotNetCore.Domain;
using System.Collections.Generic;

namespace Architecture.Domain
{
    public class UserEntity : Entity<long>
    {
        public UserEntity
        (
            long id,
            FullName fullName,
            Email email,
            Sign sign,
            Status status
        )
            : base(id)
        {
            FullName = fullName;
            Email = email;
            Sign = sign;
            Status = status;
        }

        public UserEntity(long id) : base(id)
        {
        }

        public FullName FullName { get; private set; }

        public Email Email { get; private set; }

        public Sign Sign { get; }

        public Status Status { get; private set; }

        public IReadOnlyCollection<UserLogEntity> UsersLogs { get; private set; }

        public void Add()
        {
            Status = Status.Active;
        }

        public void ChangeEmail(string address)
        {
            Email = new Email(address);
        }

        public void ChangeFullName(string name, string surname)
        {
            FullName = new FullName(name, surname);
        }

        public void Inactivate()
        {
            Status = Status.Inactive;
        }
    }
}
