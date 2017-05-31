using OnBase;
using SoccerManager.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerManager.DAL
{
    public class PatrocinadorDAO : BaseDataAccess<Imagem>
    {
        public PatrocinadorDAO() : base(new DataContext())
        {

        }
    }
}
