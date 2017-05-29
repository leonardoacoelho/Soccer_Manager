namespace SoccerManager.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Clube_Possui_Jogador : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clubes", "TemJogadores", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clubes", "TemJogadores");
        }
    }
}
