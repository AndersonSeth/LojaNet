using Microsoft.AspNetCore.Mvc;
using LojaNet.UI.Web.Models;
using System.Diagnostics;
using LojaNet.Models; 

namespace LojaNet.UI.Web.Controllers
{
    public class ClienteController : Controller
    {

        public ActionResult Incluir()
        {
            var cli = new Cliente();
            return View(cli);
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}
