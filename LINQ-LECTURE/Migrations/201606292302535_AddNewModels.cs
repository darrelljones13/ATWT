namespace GamerLinqDemoApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNewModels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Characters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IsHuman = c.Boolean(nullable: false),
                        Birthday = c.DateTime(nullable: false),
                        GameId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Games", t => t.GameId, cascadeDelete: true)
                .Index(t => t.GameId);
            
            CreateTable(
                "dbo.Games",
                c => new
                    {
                        GameId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        GameSystem_Id = c.Int(),
                    })
                .PrimaryKey(t => t.GameId)
                .ForeignKey("dbo.GameSystems", t => t.GameSystem_Id)
                .Index(t => t.GameSystem_Id);
            
            CreateTable(
                "dbo.GameSystems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SystemName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.AspNetUsers", "Game_GameId", c => c.Int());
            CreateIndex("dbo.AspNetUsers", "Game_GameId");
            AddForeignKey("dbo.AspNetUsers", "Game_GameId", "dbo.Games", "GameId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUsers", "Game_GameId", "dbo.Games");
            DropForeignKey("dbo.Games", "GameSystem_Id", "dbo.GameSystems");
            DropForeignKey("dbo.Characters", "GameId", "dbo.Games");
            DropIndex("dbo.AspNetUsers", new[] { "Game_GameId" });
            DropIndex("dbo.Games", new[] { "GameSystem_Id" });
            DropIndex("dbo.Characters", new[] { "GameId" });
            DropColumn("dbo.AspNetUsers", "Game_GameId");
            DropTable("dbo.GameSystems");
            DropTable("dbo.Games");
            DropTable("dbo.Characters");
        }
    }
}
