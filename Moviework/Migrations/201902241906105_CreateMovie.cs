namespace Moviework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateMovie : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        Title = c.String(nullable: false, maxLength: 128),
                        Year = c.Int(nullable: false),
                        Badget = c.String(),
                        Category = c.String(),
                    })
                .PrimaryKey(t => t.Title);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Movies");
        }
    }
}
