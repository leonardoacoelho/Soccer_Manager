using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerManager.DAL.Configurations
{
    public class FormacaoTaticaConfig : EntityTypeConfiguration<FormacaoTatica>
    {
        public FormacaoTaticaConfig()
        {
            ToTable("FormacoesTaticas");

            Ignore(x => x.Descricao);
        }
    }
}
