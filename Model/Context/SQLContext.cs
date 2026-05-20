using Microsoft.EntityFrameworkCore;

namespace Model.Context
{
    public class SQLContext : DbContext
    {
        public SQLContext(DbContextOptions<SQLContext> options) : base(options)
        {
        }

        public DbSet<Person> Persons { get; set; }
    }
}