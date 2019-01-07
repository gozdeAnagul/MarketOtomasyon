namespace Market.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class A6 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kategoriler",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        KategoriAdi = c.String(nullable: false, maxLength: 50),
                        Aciklama = c.String(maxLength: 50),
                        UstKategoriId = c.Guid(),
                        Kdv = c.Double(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Kategoriler", t => t.UstKategoriId)
                .Index(t => t.UstKategoriId);
            
            CreateTable(
                "dbo.Urunler",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        UrunAdi = c.String(nullable: false, maxLength: 50),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        Urun_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Urunler", t => t.Urun_Id)
                .Index(t => t.Urun_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Urunler", "Urun_Id", "dbo.Urunler");
            DropForeignKey("dbo.Kategoriler", "UstKategoriId", "dbo.Kategoriler");
            DropIndex("dbo.Urunler", new[] { "Urun_Id" });
            DropIndex("dbo.Kategoriler", new[] { "UstKategoriId" });
            DropTable("dbo.Urunler");
            DropTable("dbo.Kategoriler");
        }
    }
}
