using System.Threading.Tasks;

namespace Architecture.Database.Database
{
    public interface IUnitOfWork
    {
        Task<int> SaveChangesAsync();
    }
}
