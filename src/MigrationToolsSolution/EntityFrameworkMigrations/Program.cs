using EntityFrameworkMigrations.Model;
using SampleEntities;

namespace EntityFrameworkMigrations
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var dbModel = new FactoryContext())
            {
                dbModel.ManufacturerSet.Add(new Manufacturer { Name = "Toyota" });
                dbModel.SaveChanges();

            }
        }
    }
}
