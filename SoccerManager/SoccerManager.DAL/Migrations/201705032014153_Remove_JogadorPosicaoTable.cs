namespace SoccerManager.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Remove_JogadorPosicaoTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Posicoes", "Jogador_Id", "dbo.Jogadores");
            DropForeignKey("dbo.JogadorPosicao", "Jogador_Id1", "dbo.Jogadores");
            DropForeignKey("dbo.JogadorPosicao", "Posicao_Id1", "dbo.Posicoes");
            DropIndex("dbo.Posicoes", new[] { "Jogador_Id" });
            DropIndex("dbo.JogadorPosicao", new[] { "Jogador_Id1" });
            DropIndex("dbo.JogadorPosicao", new[] { "Posicao_Id1" });
            AddColumn("dbo.Jogadores", "Posicao_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Jogadores", "Posicao_Id");
            AddForeignKey("dbo.Jogadores", "Posicao_Id", "dbo.Posicoes", "Id", cascadeDelete: true);
            DropColumn("dbo.Posicoes", "Jogador_Id");
            DropTable("dbo.JogadorPosicao");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.JogadorPosicao",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Jogador_Id = c.Int(nullable: false),
                        Posicao_Id = c.Int(nullable: false),
                        Jogador_Id1 = c.Int(),
                        Posicao_Id1 = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Posicoes", "Jogador_Id", c => c.Int());
            DropForeignKey("dbo.Jogadores", "Posicao_Id", "dbo.Posicoes");
            DropIndex("dbo.Jogadores", new[] { "Posicao_Id" });
            DropColumn("dbo.Jogadores", "Posicao_Id");
            CreateIndex("dbo.JogadorPosicao", "Posicao_Id1");
            CreateIndex("dbo.JogadorPosicao", "Jogador_Id1");
            CreateIndex("dbo.Posicoes", "Jogador_Id");
            AddForeignKey("dbo.JogadorPosicao", "Posicao_Id1", "dbo.Posicoes", "Id");
            AddForeignKey("dbo.JogadorPosicao", "Jogador_Id1", "dbo.Jogadores", "Id");
            AddForeignKey("dbo.Posicoes", "Jogador_Id", "dbo.Jogadores", "Id");
        }
    }
}
