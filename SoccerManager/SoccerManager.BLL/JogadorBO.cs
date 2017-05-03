using OnBase;
using SoccerManager.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerManager.BLL
{
    public class JogadorBO : BaseLogic<Jogador, JogadorDAO>
    {
        public override void Save(Jogador entity)
        {
            if (string.IsNullOrEmpty(entity.Nome))
                throw new ArgumentNullException("Os campos em negrito são obrigatórios!");

            if(entity.Salario == null || entity.SkillCabeceio == null || entity.SkillChute == null || entity.SkillDefesa == null || entity.SkillMarcacao == null)
                throw new ArgumentNullException("Os campos em negrito são obrigatórios!");

            base.Save(entity);
        }

        public void Save(Jogador entity, Imagem imagem)
        {
            try
            {
                using (var bo = new ImagemBO())
                {
                    bo.Save(imagem);
                    entity.Foto_Id = imagem.Id;
                }

                Save(entity);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
