using Invelop.Task.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Invelop.Task.DAL
{
    public class PersonContext : DbContext
    {
        public PersonContext() : base("PersonContext")
        {
            Database.Connection.Open();
            //Database.SetInitializer(new CreateDatabaseIfNotExists<PersonContext>());
        }

        public DbSet<Person> People { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}