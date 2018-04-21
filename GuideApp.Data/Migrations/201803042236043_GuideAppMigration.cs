namespace GuideApp.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GuideAppMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tips",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Title = c.String(),
                        Content = c.String(),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tips");
        }
    }
}
