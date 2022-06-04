namespace TestTaskAkvelon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Project",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        CompletionDate = c.DateTime(nullable: false),
                        ProjectStatus = c.Int(nullable: false),
                        Priority = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Task",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        TaskStatus = c.Int(nullable: false),
                        Description = c.String(nullable: false),
                        Priority = c.Int(nullable: false),
                        ProjectId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Project", t => t.ProjectId, cascadeDelete: true)
                .Index(t => t.ProjectId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Task", "ProjectId", "dbo.Project");
            DropIndex("dbo.Task", new[] { "ProjectId" });
            DropTable("dbo.Task");
            DropTable("dbo.Project");
        }
    }
}
