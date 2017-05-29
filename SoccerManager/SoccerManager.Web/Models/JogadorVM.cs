using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SoccerManager.Web.Models
{
    public class JogadorVM
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Display(Name = "Apelido")]
        public string Apelido { get; set; }

        [Display(Name = "Posição")]
        public Posicao Posicao { get; set; }

        [Display(Name = "Posição")]
        public int Posicao_Id { get; set; }

        public SelectList Posicoes { get; set; }

        [Display(Name = "Clube Atual")]
        public Clube ClubeAtual { get; set; }

        [Display(Name = "Clube Atual")]
        public int? ClubeAtual_Id { get; set; }

        [Display(Name = "Data de Transferência"), DisplayFormat(DataFormatString = "{0: dd/MM/yyyy}")]
        public DateTime DataTransferencia { get; set; }

        [Display(Name = "Salário")]
        public double Salario { get; set; }

        [Display(Name = "Skill Chute"), Range(1, 99)]
        public int SkillChute { get; set; }

        [Display(Name = "Skill Passe"), Range(1, 99)]
        public int SkillPasse { get; set; }

        [Display(Name = "Skill Cabeceio"), Range(1, 99)]
        public int SkillCabeceio { get; set; }

        [Display(Name = "Skill Marcação"), Range(1, 99)]
        public int SkillMarcacao { get; set; }

        [Display(Name = "Skill Defesa"), Range(1, 99)]
        public int SkillDefesa { get; set; }

        [Display(Name = "Overall")]
        public double Overall { get; set; }

        [Display(Name = "Foto")]
        public Imagem Foto { get; set; }

        [Display(Name = "Foto")]
        public int? Foto_Id { get; set; }
    }
}