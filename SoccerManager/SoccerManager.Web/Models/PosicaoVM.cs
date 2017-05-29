using SoccerManager.Enumerators;
using SoccerManager.Web.Models.Base;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SoccerManager.Web.Models
{
    public class PosicaoVM : BaseVM
    {
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Display(Name = "Linha")]
        public TipoLinha Linha { get; set; }
    }
}