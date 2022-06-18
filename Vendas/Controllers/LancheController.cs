using Microsoft.AspNetCore.Mvc;
using Vendas.Repositories.Interfaces;
using Vendas.ViewModels;

namespace Vendas.Controllers
{
    public class LancheController : Controller
    {
        public readonly ILancheRepository _lancheRepository;
        public LancheController(ILancheRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }

        public IActionResult List()
        {
            //var lanches = _lancheRepository.Lanches;
            //return View(lanches);
            var lanchesListViewModel = new LancheListViewModel();
            lanchesListViewModel.Lanches = _lancheRepository.Lanches;
            lanchesListViewModel.CategoriaAtual = "Categoria Atual";

            return View(lanchesListViewModel);

        }
    }
}
