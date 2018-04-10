namespace Bibliotek.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bogs",
                c => new
                    {
                        BogId = c.Int(nullable: false, identity: true),
                        Titel = c.String(),
                        Beskrivelse = c.String(),
                        ImageURL = c.String(),
                        Forfatter_ForfatterId = c.Int(),
                        Genre_GenreId = c.Int(),
                    })
                .PrimaryKey(t => t.BogId)
                .ForeignKey("dbo.Forfatters", t => t.Forfatter_ForfatterId)
                .ForeignKey("dbo.Genres", t => t.Genre_GenreId)
                .Index(t => t.Forfatter_ForfatterId)
                .Index(t => t.Genre_GenreId);
            
            CreateTable(
                "dbo.Forfatters",
                c => new
                    {
                        ForfatterId = c.Int(nullable: false, identity: true),
                        Navn = c.String(),
                        Beskrivelse = c.String(),
                    })
                .PrimaryKey(t => t.ForfatterId);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        GenreId = c.Int(nullable: false, identity: true),
                        Navn = c.String(),
                    })
                .PrimaryKey(t => t.GenreId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bogs", "Genre_GenreId", "dbo.Genres");
            DropForeignKey("dbo.Bogs", "Forfatter_ForfatterId", "dbo.Forfatters");
            DropIndex("dbo.Bogs", new[] { "Genre_GenreId" });
            DropIndex("dbo.Bogs", new[] { "Forfatter_ForfatterId" });
            DropTable("dbo.Genres");
            DropTable("dbo.Forfatters");
            DropTable("dbo.Bogs");
        }
    }
}
