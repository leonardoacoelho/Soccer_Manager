using System.Web.Mvc;
using SoccerManager.BLL;
using SoccerManager.Web.Controllers.Base;
using SoccerManager.Web.Models;
using System.Linq;
using AutoMapper;
using System.Collections.Generic;
using SoccerManager.Web.Utils;

namespace SoccerManager.Web.Controllers
{
    public class ClubeController : BaseController<Clube, ClubeVM, ClubeBO>
    {
        public override ActionResult Adicionar()
        {
            var clubeVm = new ClubeVM
            {
                FormacoesTaticas = PreencherFormacoesTaticas()
            };

            return View(clubeVm);
        }

        public override ActionResult Editar(int? id)
        {
            var viewModel = GetViewModel(id);

            if (viewModel == null)
                return HttpNotFound();

            viewModel.FormacoesTaticas = PreencherFormacoesTaticas();

            return View(viewModel);
        }

        public override ActionResult Remover(int? id)
        {
            var viewModel = GetViewModel(id);

            if (viewModel == null)
                return HttpNotFound();

            if (viewModel.TemJogadores)
                return HttpNotFound();

            return View(viewModel);
        }

        public SelectList PreencherFormacoesTaticas()
        {
            using (var bo = new FormacaoTaticaBO())
            {
                var formacoes = bo.List();
                return formacoes.Select(x => new SelectListItem { Text = x.Descricao, Value = x.Id.ToString() }).ToSelectList();
            }
        }
    }
}