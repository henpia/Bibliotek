namespace Bibliotek.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TilføjetAnnotationsfortablenames : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Bogs", newName: "Bog");
            RenameTable(name: "dbo.Forfatters", newName: "Forfatter");
            RenameTable(name: "dbo.Genres", newName: "Genre");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Genre", newName: "Genres");
            RenameTable(name: "dbo.Forfatter", newName: "Forfatters");
            RenameTable(name: "dbo.Bog", newName: "Bogs");
        }
    }
}
