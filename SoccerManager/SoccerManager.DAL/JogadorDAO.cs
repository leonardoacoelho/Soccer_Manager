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
    public class JogadorDAO : BaseDataAccess<Jogador>
    {
        public JogadorDAO() : base(new DataContext())
        {

        }

        public override List<Jogador> List()
        {
            using (var context = new DataContext())
            {
                return context.Jogadores
                    .Include(x => x.ClubeAtual)
                    .ToList();
            }
        }

        public override Jogador Get(int id)
        {
            using (var context = new DataContext())
            {
                return context.Jogadores.Include(x => x.ClubeAtual).FirstOrDefault(x => x.Id == id);
            }
        }
    }
}
