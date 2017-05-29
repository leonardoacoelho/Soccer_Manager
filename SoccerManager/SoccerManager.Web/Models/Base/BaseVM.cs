using OnBase.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoccerManager.Web.Models.Base
{
    public abstract class BaseVM : IBase
    {
        public int Id { get; set; }
    }
}