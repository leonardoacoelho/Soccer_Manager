namespace SoccerManager.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Alterar_Clube_Id_Nullavel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Transferencias", "Clube_Id", "dbo.Clubes");
            DropIndex("dbo.Transferencias", new[] { "Clube_Id" });
            AlterColumn("dbo.Transferencias", "Clube_Id", c => c.Int());
            CreateIndex("dbo.Transferencias", "Clube_Id");
            AddForeignKey("dbo.Transferencias", "Clube_Id", "dbo.Clubes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transferencias", "Clube_Id", "dbo.Clubes");
            DropIndex("dbo.Transferencias", new[] { "Clube_Id" });
            AlterColumn("dbo.Transferencias", "Clube_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Transferencias", "Clube_Id");
            AddForeignKey("dbo.Transferencias", "Clube_Id", "dbo.Clubes", "Id", cascadeDelete: true);
        }
    }
}
