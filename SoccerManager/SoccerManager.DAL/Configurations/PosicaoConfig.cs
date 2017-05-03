using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerManager.DAL.Configurations
{
    public class PosicaoConfig : EntityTypeConfiguration<Posicao>
    {
        public PosicaoConfig()
        {
            ToTable("Posicoes");
        }
    }
}
