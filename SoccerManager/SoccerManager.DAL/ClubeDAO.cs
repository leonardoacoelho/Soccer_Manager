using OnBase;
using SoccerManager.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace SoccerManager.DAL
{
    public class ClubeDAO : BaseDataAccess<Clube>
    {
        public ClubeDAO() : base(new DataContext())
        {
            
        }

        public override Clube Get(int id)
        {
            using (var context = new DataContext())
            {
                return context.Clubes.Include(x => x.Escudo).FirstOrDefault(x => x.Id == id);
            }
        }
    }
}
