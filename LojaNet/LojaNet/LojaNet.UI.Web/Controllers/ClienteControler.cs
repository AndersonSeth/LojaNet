using Microsoft.AspNetCore.Mvc;
using LojaNet.UI.Web.Models;
using System.Diagnostics;

namespace LojaNet.UI.Web.Controllers
{
    public class ClienteControler : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
