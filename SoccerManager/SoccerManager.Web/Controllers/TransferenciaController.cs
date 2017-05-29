using SoccerManager.BLL;
using SoccerManager.Web.Controllers.Base;
using SoccerManager.Web.Models;
using SoccerManager.Web.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SoccerManager.Web.Controllers
{
    public class TransferenciaController : BaseController<Transferencia, TransferenciaVM, TranferenciaBO>
    {
        public override ActionResult Adicionar()
        {
            var transferenciaVm = new TransferenciaVM
            {
                Jogadores = PreencherJogadores(),
                Clubes = PreencherClubes()
            };

            return View(transferenciaVm);
        }

        protected override void PostViewModelError(TransferenciaVM viewModel)
        {
            viewModel.Clubes = PreencherClubes();
            viewModel.Jogadores = PreencherJogadores();
        }

        public override ActionResult Editar(int? id)
        {
            var transferenciaVm = new TransferenciaVM
            {
                Jogadores = PreencherJogadores(),
                Clubes = PreencherClubes()
            };

            return View(transferenciaVm);
        }

        public SelectList PreencherJogadores()
        {
            using (var bo = new JogadorBO())
            {
                var jogadores = bo.List();
                return jogadores.Select(x => new SelectListItem { Text = x.Nome, Value = x.Id.ToString() }).ToSelectList();
            }
        }

        public SelectList PreencherClubes()
        {
            using (var bo = new ClubeBO())
            {
                var clubes = bo.List();
                return clubes.Select(x => new SelectListItem { Text = x.Nome, Value = x.Id.ToString() }).ToSelectList();
            }
        }
    }
}