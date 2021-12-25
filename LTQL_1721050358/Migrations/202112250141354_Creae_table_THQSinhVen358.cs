namespace LTQL_1721050358.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Creae_table_THQSinhVen358 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.THQSinhVien358",
                c => new
                    {
                        MaSinhVien = c.String(nullable: false, maxLength: 20),
                        HoTen = c.String(maxLength: 50),
                        MaLop = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaSinhVien);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.THQSinhVien358");
        }
    }
}
