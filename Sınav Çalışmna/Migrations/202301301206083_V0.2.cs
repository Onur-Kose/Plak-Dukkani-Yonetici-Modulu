namespace Sınav_Çalışmna.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V02 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Admins", "Sifre", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Admins", "Sifre", c => c.Int(nullable: false));
        }
    }
}
