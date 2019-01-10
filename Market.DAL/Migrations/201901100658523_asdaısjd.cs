namespace Market.DAL.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class asdaısjd : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Urunler", "Kdv", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Urunler", "Kdv", c => c.Double(nullable: false));
        }
    }
}
