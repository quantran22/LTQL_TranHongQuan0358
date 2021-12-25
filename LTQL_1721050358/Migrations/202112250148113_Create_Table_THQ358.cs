namespace LTQL_1721050358.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_THQ358 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.THQSinhVien358", "MaLop");
            AddForeignKey("dbo.THQSinhVien358", "MaLop", "dbo.LopHoc358", "Malop", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.THQSinhVien358", "MaLop", "dbo.LopHoc358");
            DropIndex("dbo.THQSinhVien358", new[] { "MaLop" });
        }
    }
}
