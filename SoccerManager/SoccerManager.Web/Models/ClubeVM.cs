using SoccerManager.Web.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SoccerManager.Web.Models
{
    public class ClubeVM : BaseVM
    {
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Display(Name = "Sigla")]
        public string Sigla { get; set; }

        [Display(Name = "Formação Tática")]
        public FormacaoTatica FormacaoTatica { get; set; }

        [Display(Name = "Formação Tática")]
        public int FormacaoTatica_Id { get; set; }

        public SelectList FormacoesTaticas { get; set; }

        [Display(Name = "Jogadores")]
        public List<Jogador> Jogadores { get; set; }

        [Display(Name = "Escudo")]
        public Imagem Escudo { get; private set; }

        [Display(Name = "Escudo")]
        public int? Escudo_Id { get; set; }

        public bool TemJogadores { get; set; }
    }
}