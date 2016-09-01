using SampleEntities;
using System.Data.Entity;

namespace EntityFrameworkMigrations.Model
{
    public class FactoryContext: DbContext
    {
        public FactoryContext()
            :base("DefaultConnection")
        {

        }
        public DbSet<Manufacturer> ManufacturerSet { get; set; }
    }
}
