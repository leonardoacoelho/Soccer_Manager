using System.Web.Mvc;
using SoccerManager.BLL;
using SoccerManager.Web.Controllers.Base;
using SoccerManager.Web.Models;
using System.Linq;
using SoccerManager.Web.Utils;
using System;

namespace SoccerManager.Web.Controllers
{
    public class JogadorController : BaseController<Jogador, JogadorVM, JogadorBO>
    {
        public override ActionResult Adicionar()
        {
            var jogadorVm = new JogadorVM
            {
                Posicoes = Preencherposicoes()
            };

            return View(jogadorVm);
        }

        public override ActionResult Adicionar(JogadorVM viewModel)
        {
            viewModel.DataTransferencia = DateTime.Today;

            return base.Adicionar(viewModel);
        }

        public override ActionResult Editar(int? id)
        {
            var jogadorVm = GetViewModel(id);
            jogadorVm.Posicoes = Preencherposicoes();

            return View(jogadorVm);
        }

        public SelectList Preencherposicoes()
        {
            using (var bo = new PosicaoBO())
            {
                var posicoes = bo.List();
                return posicoes.Select(x => new SelectListItem { Text = x.Descricao, Value = x.Id.ToString() }).ToSelectList();
            }
        }
    }
}