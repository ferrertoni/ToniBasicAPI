using System.Data.Entity;
using t.domain.Entities;

namespace t.data.EF
{
    public class EFDbContext: DbContext
    {
        public EFDbContext() : base("Data Source=localhost;Initial Catalog=ToniApps;Persist Security Info=True;User ID=sa;Password=saroot"){}

        public DbSet<Post> Post { get; set; }
        public DbSet<Topic> Topic { get; set; }
        public DbSet<User> User { get; set; }
        
    }
    
}
