namespace AEproject.DL
{
    using Microsoft.EntityFrameworkCore;
    using Model;

    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        { }

        public DbSet<User> Users { get; set; }
    }
}