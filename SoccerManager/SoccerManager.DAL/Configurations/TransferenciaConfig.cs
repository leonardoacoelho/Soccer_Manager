using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerManager.DAL.Configurations
{
    public class TransferenciaConfig : EntityTypeConfiguration<Transferencia>
    {
        public TransferenciaConfig()
        {
            ToTable("Transferencias");

            HasRequired(t => t.Jogador)
                .WithMany()
                .HasForeignKey(x => x.Jogador_Id);

            HasOptional(t => t.Clube)
                .WithMany()
                .HasForeignKey(x => x.Clube_Id);
        }
    }
}
