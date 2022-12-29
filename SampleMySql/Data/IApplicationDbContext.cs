using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Data;

namespace SampleMySql.Data
{
    public interface IApplicationDbContext : IDisposable
    {
        public IDbConnection Connection { get; }
        DatabaseFacade Database { get; }
        //public DbSet<Group> Groups { get; set; }
        //public DbSet<ApplicationRole> Roles { get; set; }
        //Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        //Task<IReadOnlyList<T>> QueryAsync<T>(string sql, object? param = null, IDbTransaction? transaction = null, CancellationToken cancellationToken = default);
    }
}
