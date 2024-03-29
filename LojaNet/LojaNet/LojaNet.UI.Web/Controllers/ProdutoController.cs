using Microsoft.AspNetCore.Mvc;

namespace LojaNet.UI.Web.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
