using System.Data.Entity;
using Data.Entities;

namespace Data
{
    public class EntitySplittingContext : DbContext
    {
        public IDbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Using typeof(EntitySplittingContext).Assembly instead of GetType().Assembly
            // so that config types are loaded in LinqPad:
            // http://forum.linqpad.net/discussion/507/tip-when-using-ef-and-fluent-api-the-context-is-not-what-it-seems
            modelBuilder.Configurations.AddFromAssembly(typeof(EntitySplittingContext).Assembly);
        }
    }
}
