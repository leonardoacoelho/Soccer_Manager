using OnBase;
using SoccerManager.Enumerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerManager
{
    public class Posicao : Base
    {
        public string Descricao { get; set; }

        public TipoLinha Linha { get; set; }

        public override string ToString()
        {
            return Descricao;
        }
    }
}
