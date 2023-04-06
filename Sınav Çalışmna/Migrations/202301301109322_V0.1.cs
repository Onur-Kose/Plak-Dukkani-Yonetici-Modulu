namespace Sınav_Çalışmna.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V01 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        AdminID = c.Int(nullable: false, identity: true),
                        AdminName = c.String(),
                        Sifre = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AdminID);
            
            CreateTable(
                "dbo.Albums",
                c => new
                    {
                        AlbumID = c.Int(nullable: false, identity: true),
                        AlbunName = c.String(),
                        Sanatci = c.String(),
                        Tarih = c.DateTime(nullable: false),
                        Fiyat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Indirim = c.Decimal(nullable: true, precision: 18, scale: 2),
                        SatışıVarMı = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.AlbumID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Albums");
            DropTable("dbo.Admins");
        }
    }
}
