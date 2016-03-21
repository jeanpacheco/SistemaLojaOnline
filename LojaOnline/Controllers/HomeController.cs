using LojaOnline.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LojaOnline.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult GetBicicletas()
        {
            List<Models.BicicletaViewModel> obj = new List<Models.BicicletaViewModel>(Models.BicicletaViewModel.Listar());
            return Json(obj);
        }

        [HttpPost]
        public JsonResult AtualizarPreco(int id, string modelo, int preco)
        {
            BicicletaViewModel bicicleta = new BicicletaViewModel();
            bicicleta.Id = id;
            bicicleta.Modelo = modelo;
            bicicleta.Preco = preco;
            int obj = (Models.BicicletaViewModel.Atualizar(bicicleta));
            return Json(obj);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}