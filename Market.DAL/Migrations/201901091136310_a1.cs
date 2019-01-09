namespace Market.DAL.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class a1 : DbMigration
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
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Fisler", t => t.FisId, cascadeDelete: true)
                .ForeignKey("dbo.UrunDetaylar", t => t.UrunDetayId, cascadeDelete: true)
                .Index(t => t.UrunDetayId)
                .Index(t => t.FisId);

            CreateTable(
                "dbo.UrunDetaylar",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    UrunId = c.Int(nullable: false),
                    KoliIciAdet = c.Int(nullable: false),
                    Barkod = c.String(maxLength: 50),
                    Aciklama = c.String(maxLength: 50),
                    Kdv = c.Double(nullable: false),
                    KoliAdet = c.Int(nullable: false),
                    UrunAdet = c.Int(nullable: false),
                    AlisFiyat = c.Decimal(nullable: false, precision: 18, scale: 2),
                    SatisFiyat = c.Decimal(nullable: false, precision: 18, scale: 2),
                    IsActive = c.Boolean(nullable: false),
                    IsDeleted = c.Boolean(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Urunler", t => t.UrunId, cascadeDelete: true)
                .Index(t => t.UrunId)
                .Index(t => t.Barkod, unique: true);

            CreateTable(
                "dbo.Urunler",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    UrunAdi = c.String(nullable: false, maxLength: 50),
                    KategoriId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Kategoriler", t => t.KategoriId, cascadeDelete: true)
                .Index(t => t.UrunAdi, unique: true)
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
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Kategoriler", t => t.UstKategoriId)
                .Index(t => t.UstKategoriId);

        }

        public override void Down()
        {
            DropForeignKey("dbo.Satislar", "UrunDetayId", "dbo.UrunDetaylar");
            DropForeignKey("dbo.UrunDetaylar", "UrunId", "dbo.Urunler");
            DropForeignKey("dbo.Urunler", "KategoriId", "dbo.Kategoriler");
            DropForeignKey("dbo.Kategoriler", "UstKategoriId", "dbo.Kategoriler");
            DropForeignKey("dbo.Satislar", "FisId", "dbo.Fisler");
            DropIndex("dbo.Kategoriler", new[] { "UstKategoriId" });
            DropIndex("dbo.Urunler", new[] { "KategoriId" });
            DropIndex("dbo.Urunler", new[] { "UrunAdi" });
            DropIndex("dbo.UrunDetaylar", new[] { "Barkod" });
            DropIndex("dbo.UrunDetaylar", new[] { "UrunId" });
            DropIndex("dbo.Satislar", new[] { "FisId" });
            DropIndex("dbo.Satislar", new[] { "UrunDetayId" });
            DropTable("dbo.Kategoriler");
            DropTable("dbo.Urunler");
            DropTable("dbo.UrunDetaylar");
            DropTable("dbo.Satislar");
            DropTable("dbo.Fisler");
        }
    }
}
