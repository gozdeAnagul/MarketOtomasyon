namespace Market.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Computed : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Fisler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GenelToplam = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OdemeYontemi = c.Byte(nullable: false),
                        FisTarihi = c.DateTime(nullable: false),
                        EklenmeZamani = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Satislar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UrunDetayId = c.Int(nullable: false),
                        SatisAdeti = c.Int(nullable: false),
                        FisId = c.Int(nullable: false),
                        EklenmeZamani = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Fisler", t => t.FisId, cascadeDelete: true)
                .ForeignKey("dbo.Urunler", t => t.UrunDetayId, cascadeDelete: true)
                .Index(t => t.UrunDetayId)
                .Index(t => t.FisId);
            
            CreateTable(
                "dbo.Urunler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UrunAdi = c.String(nullable: false, maxLength: 50),
                        Aciklama = c.String(maxLength: 50),
                        KoliAdet = c.Int(nullable: false),
                        KoliIciAdet = c.Int(nullable: false),
                        Stok = c.Int(nullable: false),
                        Kdv = c.Double(nullable: false),
                        KoliBarkod = c.String(maxLength: 50),
                        UrunBarkod = c.String(maxLength: 50),
                        AlisFiyat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SatisFiyat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        KategoriId = c.Int(nullable: false),
                        EklenmeZamani = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Kategoriler", t => t.KategoriId, cascadeDelete: true)
                .Index(t => t.UrunAdi, unique: true)
                .Index(t => t.KoliBarkod, unique: true)
                .Index(t => t.UrunBarkod, unique: true)
                .Index(t => t.KategoriId);
            
            CreateTable(
                "dbo.Kategoriler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KategoriAdi = c.String(nullable: false, maxLength: 50),
                        Aciklama = c.String(maxLength: 50),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        UstKategoriId = c.Int(),
                        EklenmeZamani = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Kategoriler", t => t.UstKategoriId)
                .Index(t => t.UstKategoriId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Satislar", "UrunDetayId", "dbo.Urunler");
            DropForeignKey("dbo.Urunler", "KategoriId", "dbo.Kategoriler");
            DropForeignKey("dbo.Kategoriler", "UstKategoriId", "dbo.Kategoriler");
            DropForeignKey("dbo.Satislar", "FisId", "dbo.Fisler");
            DropIndex("dbo.Kategoriler", new[] { "UstKategoriId" });
            DropIndex("dbo.Urunler", new[] { "KategoriId" });
            DropIndex("dbo.Urunler", new[] { "UrunBarkod" });
            DropIndex("dbo.Urunler", new[] { "KoliBarkod" });
            DropIndex("dbo.Urunler", new[] { "UrunAdi" });
            DropIndex("dbo.Satislar", new[] { "FisId" });
            DropIndex("dbo.Satislar", new[] { "UrunDetayId" });
            DropTable("dbo.Kategoriler");
            DropTable("dbo.Urunler");
            DropTable("dbo.Satislar");
            DropTable("dbo.Fisler");
        }
    }
}
