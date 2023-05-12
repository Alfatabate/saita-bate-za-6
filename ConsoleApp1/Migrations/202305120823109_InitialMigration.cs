namespace ConsoleApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Breeds",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Cats",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Age = c.Int(nullable: false),
                        BreedId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Breeds", t => t.BreedId, cascadeDelete: true)
                .Index(t => t.BreedId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cats", "BreedId", "dbo.Breeds");
            DropIndex("dbo.Cats", new[] { "BreedId" });
            DropTable("dbo.Cats");
            DropTable("dbo.Breeds");
        }
    }
}
