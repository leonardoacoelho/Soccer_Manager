using OnBase;
using SoccerManager.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerManager.BLL
{
    public class PosicaoBO : BaseLogic<Posicao, PosicaoDAO>
    {
        public override void Save(Posicao entity)
        {
            if(string.IsNullOrEmpty(entity.Descricao))
                throw new ArgumentNullException("Os campos em negrito são obrigatórios!");
            base.Save(entity);
        }
    }
}
