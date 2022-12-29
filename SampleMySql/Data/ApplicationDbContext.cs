using Microsoft.EntityFrameworkCore;
using System.Data;

namespace SampleMySql.Data
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public IDbConnection Connection => Database.GetDbConnection();

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
