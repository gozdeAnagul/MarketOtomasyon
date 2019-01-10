namespace Market.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Computed2 : DbMigration
    {
        public override void Up()
        {
            Sql("ALTER TABLE dbo.Urunler DROP COLUMN Stok");
            Sql("ALTER TABLE dbo.Urunler ADD [Stok] as ([KoliAdet] * [KoliIciAdet])");
        }
        
        public override void Down()
        {
            DropTable("dbo.Urunler");
        }
    }
}
