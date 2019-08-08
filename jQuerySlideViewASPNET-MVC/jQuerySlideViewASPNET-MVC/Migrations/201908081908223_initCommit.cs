namespace jQuerySlideViewASPNET_MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initCommit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StudentInformations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CodeNo = c.String(),
                        Address = c.String(),
                        ImagePath = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.StudentInformations");
        }
    }
}
