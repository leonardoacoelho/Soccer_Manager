using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerManager.DAL.Configurations
{
    public class ClubeConfig : EntityTypeConfiguration<Clube>
    {
        public ClubeConfig()
        {
            ToTable("Clubes");
            HasRequired(c => c.FormacaoTatica)
                .WithMany()
                .HasForeignKey(x => x.FormacaoTatica_Id);

            HasOptional(c => c.Escudo)
                .WithMany()
                .HasForeignKey(x => x.Escudo_Id);
        }
    }
}
