using OnBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerManager
{
    [Serializable]
    public class FormacaoTatica : Base
    {
        public int LinhaDefensiva { get; set; }

        public int LinhaCentral { get; set; }

        public int LinhaOfensiva { get; set; }

        public string Descricao {
            get { return ToString(); }
        }

        public override string ToString()
        {
            return $"{LinhaDefensiva}-{LinhaCentral}-{LinhaOfensiva}";
        }

        public FormacaoTatica()
        {

        }
    }
}
