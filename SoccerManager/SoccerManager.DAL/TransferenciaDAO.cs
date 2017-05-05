using OnBase;
using SoccerManager.DAL.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerManager.DAL
{
    public class TransferenciaDAO : BaseDataAccess<Transferencia>
    {
        public TransferenciaDAO() : base(new DataContext())
        {
            
        }

        public override Transferencia Get(int id)
        {
            using (var context = new DataContext())
            {
                return context.Transferencias.Include(x => x.Clube).Include(x => x.Jogador).FirstOrDefault(x => x.Id == id);
            }
        }

        public override List<Transferencia> List()
        {
            using (var context = new DataContext())
            {
                return context.Transferencias.Include(x => x.Clube).Include(x => x.Jogador).ToList();
            }
        }
    }
}
