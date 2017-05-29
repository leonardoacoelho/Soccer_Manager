using OnBase;
using SoccerManager.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

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
                return context.Jogadores.Include(x => x.ClubeAtual).Include(x => x.Posicao).ToList();
            }
        }

        public override Jogador Get(int id)
        {
            using (var context = new DataContext())
            {
                return context.Jogadores.Include(x => x.ClubeAtual).Include(x => x.Posicao).FirstOrDefault(x => x.Id == id);
            }
        }

        public override Jogador Get(Expression<Func<Jogador, bool>> filter)
        {
            using (var context = new DataContext())
            {
                return context.Jogadores.Include(x => x.ClubeAtual).Include(x => x.Posicao).FirstOrDefault(filter);
            }
        }

        public override List<Jogador> List(Expression<Func<Jogador, bool>> filter)
        {
            using (var context = new DataContext())
            {
                return context.Jogadores.Include(x => x.ClubeAtual).Include(x => x.Posicao).ToList();
            }
        }
    }
}
