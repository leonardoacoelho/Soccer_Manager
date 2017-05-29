using SoccerManager.Web.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SoccerManager.Web.Models
{
    public class FormacaoTaticaVM : BaseVM
    {
        [Display(Name = "Linha Defensiva")]
        public int LinhaDefensiva { get; set; }

        [Display(Name = "Linha Central")]
        public int LinhaCentral { get; set; }

        [Display(Name = "Linha Ofensiva")]
        public int LinhaOfensiva { get; set; }

        [Display(Name = "Descrição")]
        public string Descricao
        {
            get { return $"{LinhaDefensiva}-{LinhaCentral}-{LinhaOfensiva}"; }
        }
    }
}