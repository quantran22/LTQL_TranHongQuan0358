namespace LTQL_1721050358.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_table_LH358 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LopHoc358",
                c => new
                    {
                        Malop = c.Int(nullable: false, identity: true),
                        TenLop = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Malop);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.LopHoc358");
        }
    }
}
