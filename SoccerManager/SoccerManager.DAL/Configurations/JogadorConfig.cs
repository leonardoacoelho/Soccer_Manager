using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerManager.DAL.Configurations
{
    public class JogadorConfig : EntityTypeConfiguration<Jogador>
    {
        public JogadorConfig()
        {
            ToTable("Jogadores");

            HasOptional(j => j.ClubeAtual)
                .WithMany()
                .HasForeignKey(x => x.ClubeAtual_Id);

            HasOptional(j => j.Foto)
                .WithMany()
                .HasForeignKey(x => x.Foto_Id);

            HasRequired(j => j.Posicao)
                .WithMany()
                .HasForeignKey(x => x.Posicao_Id);
        }
    }
}
