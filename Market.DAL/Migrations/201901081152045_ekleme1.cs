namespace Market.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ekleme1 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Urunler", "UrunAdi", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Urunler", new[] { "UrunAdi" });
        }
    }
}
