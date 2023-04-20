using AspNet.UserIdentity.Boilerplate.Data.Configuration.Entities;
using AspNet.UserIdentity.Boilerplate.Data.Models.Entities;
using AspNet.UserIdentity.Boilerplate.Data.Models.Entities.Map;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AspNet.UserIdentity.Boilerplate.Data
{
	public class DatabaseContext : IdentityDbContext<User>
    {

		public DbSet<MyTableExample> MyTableExample { get; set; }


		public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            base.OnModelCreating(modelBuilder);
            MyTableExampleMap.Map(modelBuilder.Entity<MyTableExample>());

			modelBuilder.ApplyConfiguration(new RoleConfiguration());

        }
	}
}
