namespace Market.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deneme : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.UrunDetaylar", "UrunId", "dbo.Urunler");
            DropForeignKey("dbo.Satislar", "UrunDetayId", "dbo.UrunDetaylar");
            DropIndex("dbo.Satislar", new[] { "UrunDetayId" });
            DropIndex("dbo.UrunDetaylar", new[] { "UrunId" });
            DropIndex("dbo.UrunDetaylar", new[] { "Barkod" });
            DropIndex("dbo.UrunDetaylar", new[] { "Aciklama" });
            DropIndex("dbo.Urunler", new[] { "Barkod" });
            AddColumn("dbo.Satislar", "UrunId", c => c.Int(nullable: false));
            AddColumn("dbo.Urunler", "Aciklama", c => c.String(maxLength: 50));
            AddColumn("dbo.Urunler", "KoliAdet", c => c.Int(nullable: false));
            AddColumn("dbo.Urunler", "KoliIciAdet", c => c.Int(nullable: false));
            AddColumn("dbo.Urunler", "Kdv", c => c.Decimal(nullable: false, precision: 5, scale: 3));
            AddColumn("dbo.Urunler", "KoliBarkod", c => c.String(maxLength: 7));
            AddColumn("dbo.Urunler", "UrunBarkod", c => c.String(maxLength: 8));
            AddColumn("dbo.Urunler", "AlisFiyat", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Urunler", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Urunler", "IsDeleted", c => c.Boolean(nullable: false));
            CreateIndex("dbo.Satislar", "UrunId");
            CreateIndex("dbo.Urunler", "KoliBarkod", unique: true);
            CreateIndex("dbo.Urunler", "UrunBarkod", unique: true);
            AddForeignKey("dbo.Satislar", "UrunId", "dbo.Urunler", "Id", cascadeDelete: true);
            DropColumn("dbo.Satislar", "UrunDetayId");
            DropColumn("dbo.Urunler", "Barkod");
            DropTable("dbo.UrunDetaylar");
        }
        
        public override void Down()
        {
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
                        EklenmeZamani = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Urunler", "Barkod", c => c.String(maxLength: 50));
            AddColumn("dbo.Satislar", "UrunDetayId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Satislar", "UrunId", "dbo.Urunler");
            DropIndex("dbo.Urunler", new[] { "UrunBarkod" });
            DropIndex("dbo.Urunler", new[] { "KoliBarkod" });
            DropIndex("dbo.Satislar", new[] { "UrunId" });
            DropColumn("dbo.Urunler", "IsDeleted");
            DropColumn("dbo.Urunler", "IsActive");
            DropColumn("dbo.Urunler", "AlisFiyat");
            DropColumn("dbo.Urunler", "UrunBarkod");
            DropColumn("dbo.Urunler", "KoliBarkod");
            DropColumn("dbo.Urunler", "Kdv");
            DropColumn("dbo.Urunler", "KoliIciAdet");
            DropColumn("dbo.Urunler", "KoliAdet");
            DropColumn("dbo.Urunler", "Aciklama");
            DropColumn("dbo.Satislar", "UrunId");
            CreateIndex("dbo.Urunler", "Barkod", unique: true);
            CreateIndex("dbo.UrunDetaylar", "Aciklama", unique: true);
            CreateIndex("dbo.UrunDetaylar", "Barkod", unique: true);
            CreateIndex("dbo.UrunDetaylar", "UrunId");
            CreateIndex("dbo.Satislar", "UrunDetayId");
            AddForeignKey("dbo.Satislar", "UrunDetayId", "dbo.UrunDetaylar", "Id", cascadeDelete: true);
            AddForeignKey("dbo.UrunDetaylar", "UrunId", "dbo.Urunler", "Id", cascadeDelete: true);
        }
    }
}
