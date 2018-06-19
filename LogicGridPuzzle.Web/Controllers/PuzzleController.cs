using Microsoft.AspNetCore.Mvc;

namespace LogicGridPuzzle.Web.Controllers
{
    public class PuzzleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}