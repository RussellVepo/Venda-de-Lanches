using Microsoft.AspNetCore.Mvc;
using Venda_de_lanches.Repositories.Interfaces;

namespace Venda_de_lanches.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILancheRepository _lancheRepository;
       
        public LancheController(ILancheRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }

        public IActionResult    List()
        {
            var lanches = _lancheRepository.Lanches;
            return View(lanches);
        }
    }
}
