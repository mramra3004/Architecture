using Architecture.CrossCutting;
using Architecture.CrossCutting.Enums;
using DotNetCore.Domain;
using System;

namespace Architecture.Domain
{
    public class UserLogEntity : Entity<long>
    {
        public UserLogEntity(long userId, LogType logType) : base(default)
        {
            UserId = userId;
            LogType = logType;
            DateTime = DateTime.UtcNow;
        }

        public long UserId { get; }

        public LogType LogType { get; }

        public DateTime DateTime { get; }

        public UserEntity User { get; private set; }
    }
}
