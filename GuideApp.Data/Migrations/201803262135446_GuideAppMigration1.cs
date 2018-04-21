namespace GuideApp.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GuideAppMigration1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ContentTips",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Text = c.String(),
                        ContentImage = c.String(),
                        Tip_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Tips", t => t.Tip_Id)
                .Index(t => t.Tip_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ContentTips", "Tip_Id", "dbo.Tips");
            DropIndex("dbo.ContentTips", new[] { "Tip_Id" });
            DropTable("dbo.ContentTips");
        }
    }
}
