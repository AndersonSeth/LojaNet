using Microsoft.AspNetCore.Mvc;
using LojaNet.UI.Web.Models;
using System.Diagnostics;
using LojaNet.Models;
using LojaNet.BLL;

namespace LojaNet.UI.Web.Controllers
{
    public class ClienteController : Controller
    {
        private ClienteBLL bll;

        public ClienteController ()
        {
            bll = new ClienteBLL ();
        }
        public ActionResult Detalhes(string id)
        {
            var cliente = bll.ObterPorId(id);
            return View(cliente);


        }

        public ActionResult Incluir()
        {
            var cli = new Cliente();
            return View(cli);
        }

        [HttpPost]
            public ActionResult Incluir(Cliente cliente)
        {
            try
            {


                var bll = new ClienteBLL();
                bll.Incluir(cliente);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
                return View(cliente);
            }
        }


        public ActionResult Index()
        {
            
            var lista=bll.ObterTodos();
            return View(lista);
        }
    }
}
