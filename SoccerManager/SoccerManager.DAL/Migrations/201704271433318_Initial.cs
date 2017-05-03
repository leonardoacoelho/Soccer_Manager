namespace SoccerManager.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clubes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Sigla = c.String(),
                        FormacaoTatica_Id = c.Int(nullable: false),
                        Escudo_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Imagens", t => t.Escudo_Id)
                .ForeignKey("dbo.FormacoesTaticas", t => t.FormacaoTatica_Id)
                .Index(t => t.FormacaoTatica_Id)
                .Index(t => t.Escudo_Id);
            
            CreateTable(
                "dbo.Imagens",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        bytes = c.Binary(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FormacoesTaticas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LinhaDefensiva = c.Int(nullable: false),
                        LinhaCentral = c.Int(nullable: false),
                        LinhaOfensiva = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Jogadores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Apelido = c.String(),
                        ClubeAtual_Id = c.Int(),
                        DataTransferencia = c.DateTime(nullable: false),
                        Salario = c.Double(nullable: false),
                        SkillChute = c.Int(nullable: false),
                        SkillPasse = c.Int(nullable: false),
                        SkillCabeceio = c.Int(nullable: false),
                        SkillMarcacao = c.Int(nullable: false),
                        SkillDefesa = c.Int(nullable: false),
                        Overall = c.Int(nullable: false),
                        Foto_Id = c.Int(),
                        Clube_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clubes", t => t.ClubeAtual_Id)
                .ForeignKey("dbo.Imagens", t => t.Foto_Id)
                .ForeignKey("dbo.Clubes", t => t.Clube_Id)
                .Index(t => t.ClubeAtual_Id)
                .Index(t => t.Foto_Id)
                .Index(t => t.Clube_Id);
            
            CreateTable(
                "dbo.Posicoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        Linha = c.Int(nullable: false),
                        Jogador_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Jogadores", t => t.Jogador_Id)
                .Index(t => t.Jogador_Id);
            
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
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Jogadores", t => t.Jogador_Id1)
                .ForeignKey("dbo.Posicoes", t => t.Posicao_Id1)
                .Index(t => t.Jogador_Id1)
                .Index(t => t.Posicao_Id1);
            
            CreateTable(
                "dbo.Transferencias",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Jogador_Id = c.Int(nullable: false),
                        Clube_Id = c.Int(nullable: false),
                        Data = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clubes", t => t.Clube_Id)
                .ForeignKey("dbo.Jogadores", t => t.Jogador_Id)
                .Index(t => t.Jogador_Id)
                .Index(t => t.Clube_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transferencias", "Jogador_Id", "dbo.Jogadores");
            DropForeignKey("dbo.Transferencias", "Clube_Id", "dbo.Clubes");
            DropForeignKey("dbo.JogadorPosicao", "Posicao_Id1", "dbo.Posicoes");
            DropForeignKey("dbo.JogadorPosicao", "Jogador_Id1", "dbo.Jogadores");
            DropForeignKey("dbo.Jogadores", "Clube_Id", "dbo.Clubes");
            DropForeignKey("dbo.Posicoes", "Jogador_Id", "dbo.Jogadores");
            DropForeignKey("dbo.Jogadores", "Foto_Id", "dbo.Imagens");
            DropForeignKey("dbo.Jogadores", "ClubeAtual_Id", "dbo.Clubes");
            DropForeignKey("dbo.Clubes", "FormacaoTatica_Id", "dbo.FormacoesTaticas");
            DropForeignKey("dbo.Clubes", "Escudo_Id", "dbo.Imagens");
            DropIndex("dbo.Transferencias", new[] { "Clube_Id" });
            DropIndex("dbo.Transferencias", new[] { "Jogador_Id" });
            DropIndex("dbo.JogadorPosicao", new[] { "Posicao_Id1" });
            DropIndex("dbo.JogadorPosicao", new[] { "Jogador_Id1" });
            DropIndex("dbo.Posicoes", new[] { "Jogador_Id" });
            DropIndex("dbo.Jogadores", new[] { "Clube_Id" });
            DropIndex("dbo.Jogadores", new[] { "Foto_Id" });
            DropIndex("dbo.Jogadores", new[] { "ClubeAtual_Id" });
            DropIndex("dbo.Clubes", new[] { "Escudo_Id" });
            DropIndex("dbo.Clubes", new[] { "FormacaoTatica_Id" });
            DropTable("dbo.Transferencias");
            DropTable("dbo.JogadorPosicao");
            DropTable("dbo.Posicoes");
            DropTable("dbo.Jogadores");
            DropTable("dbo.FormacoesTaticas");
            DropTable("dbo.Imagens");
            DropTable("dbo.Clubes");
        }
    }
}
