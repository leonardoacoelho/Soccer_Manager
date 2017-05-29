using SoccerManager.Web.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SoccerManager.Web.Models
{
    public class TransferenciaVM : BaseVM
    {
        public Jogador Jogador { get; set; }

        [Display(Name = "Jogador")]
        public int Jogador_Id { get; set; }

        public SelectList Jogadores { get; set; }

        public Clube Clube { get; set; }

        [Display(Name = "Clube")]
        public int? Clube_Id { get; set; }

        public SelectList Clubes { get; set; }

        [Display(Name = "Data"), DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}"), DataType(DataType.Date)]
        public DateTime Data { get; set; }
    }
}