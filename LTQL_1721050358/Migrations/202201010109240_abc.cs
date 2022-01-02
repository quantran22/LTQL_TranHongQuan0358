namespace LTQL_1721050358.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class abc : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        UserName = c.String(nullable: false, maxLength: 128),
                        password = c.String(),
                    })
                .PrimaryKey(t => t.UserName);
            
            CreateTable(
                "dbo.LopHoc358",
                c => new
                    {
                        Malop = c.Int(nullable: false, identity: true),
                        TenLop = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Malop);
            
            CreateTable(
                "dbo.THQSinhVien358",
                c => new
                    {
                        MaSinhVien = c.String(nullable: false, maxLength: 20),
                        HoTen = c.String(maxLength: 50),
                        MaLop = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaSinhVien)
                .ForeignKey("dbo.LopHoc358", t => t.MaLop, cascadeDelete: true)
                .Index(t => t.MaLop);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.THQSinhVien358", "MaLop", "dbo.LopHoc358");
            DropIndex("dbo.THQSinhVien358", new[] { "MaLop" });
            DropTable("dbo.THQSinhVien358");
            DropTable("dbo.LopHoc358");
            DropTable("dbo.Accounts");
        }
    }
}
