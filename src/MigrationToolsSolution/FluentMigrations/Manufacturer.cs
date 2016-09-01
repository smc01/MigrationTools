using FluentMigrator;

namespace FluentMigrations
{
    [Migration(201609011255)]
    public class ManufacturerTable : Migration
    {
        public override void Up()
        {
            Create.Table("Manufacturer").WithColumn("Id").AsInt32().PrimaryKey();
        }

        public override void Down()
        {
            Delete.Table("Manufacurer");
        }
    }
}
