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
    public class ClubeDAO : BaseDataAccess<Clube>
    {
        public ClubeDAO() : base(new DataContext())
        {

        }

        public override Clube Get(int id)
        {
            using (var context = new DataContext())
            {
                return context.Clubes.Include(x => x.Escudo).Include(x => x.FormacaoTatica).FirstOrDefault(x => x.Id == id);
            }
        }

        public override List<Clube> List()
        {
            using (var context = new DataContext())
            {
                return context.Clubes.Include(x => x.FormacaoTatica).ToList();
            }
        }

        public override Clube Get(Expression<Func<Clube, bool>> filter)
        {
            using (var context = new DataContext())
            {
                return context.Clubes.Include(x => x.Escudo).Include(x => x.FormacaoTatica).FirstOrDefault(filter);
            }
        }

        public override List<Clube> List(Expression<Func<Clube, bool>> filter)
        {
            using (var context = new DataContext())
            {
                return context.Clubes.Include(x => x.FormacaoTatica).ToList();
            }
        }

        public override void Edit(Clube entidade)
        {
            using (var context = new DataContext())
            {
                context.Clubes.Attach(entidade);

                context.Entry(entidade).Property(x => x.Nome).IsModified = true;
                context.Entry(entidade).Property(x => x.Sigla).IsModified = true;
                context.Entry(entidade).Property(x => x.FormacaoTatica_Id).IsModified = true;
                context.Entry(entidade).Property(x => x.Escudo_Id).IsModified = true;

                context.SaveChanges();
            }
        }
        public void EditTemJogadores(Clube entidade)
        {
            using (var context = new DataContext())
            {
                context.Clubes.Attach(entidade);

                context.Entry(entidade).Property(x => x.TemJogadores).IsModified = true;
                
                context.SaveChanges();
            }
        }
    }
}
