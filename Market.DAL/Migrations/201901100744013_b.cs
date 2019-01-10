namespace Market.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class b : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Urunler", "SatisFiyat");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Urunler", "SatisFiyat", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
