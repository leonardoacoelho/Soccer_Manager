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

            Validar(entity);

            entity.ClubeAtual = null;

            base.Save(entity);
        }

        private void Validar(Jogador entity)
        {
            var hasErrors = false;
            var sb = new StringBuilder();

            sb.Append("Os seguintes campos devem ser preenchidos de forma válida:\n");

            if (string.IsNullOrEmpty(entity.Nome))
            {
                hasErrors = true;
                sb.Append("- Nome\n");
            }

            if (entity.Salario == 0)
            {
                hasErrors = true;
                sb.Append("- Salário\n");
            }

            if (!ValidarSkill(entity.SkillChute))
            {
                hasErrors = true;
                sb.Append("- Skill Chute\n");
            }

            if (!ValidarSkill(entity.SkillDefesa))
            {
                hasErrors = true;
                sb.Append("- Skill Defesa\n");
            }

            if (!ValidarSkill(entity.SkillMarcacao))
            {
                hasErrors = true;
                sb.Append("- Skill Marcação\n");
            }

            if (!ValidarSkill(entity.SkillCabeceio))
            {
                hasErrors = true;
                sb.Append("- Skill Cabeceio\n");
            }

            if (!ValidarSkill(entity.SkillPasse))
            {
                hasErrors = true;
                sb.Append("- Skill Passe\n");
            }

            if (hasErrors)
                throw new Exception(sb.ToString());
        }

        private bool ValidarSkill(int skill)
        {
            if (skill == 0)
                return false;

            if ((skill > 99) || (skill < 0))
                return false;

            return true;
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
