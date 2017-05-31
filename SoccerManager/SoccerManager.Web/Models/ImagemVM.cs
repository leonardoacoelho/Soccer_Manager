using SoccerManager.Web.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace SoccerManager.Web.Models
{
    public class ImagemVM : BaseVM
    {
        //[DataType(DataType.Upload)]
        public byte[] bytes { get; set; }
    }
}