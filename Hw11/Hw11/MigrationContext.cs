namespace Hw11
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class MigrationContext : DbContext
    {
        
        public MigrationContext()
            : base("name=MigrationContext")
        {
        }
        public DbSet<User> Users { get; set; }
    }
    
}