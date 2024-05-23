using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MiProyecto1.Models;

namespace MiProyecto1.Controllers
{
    public class VentasController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ActionVenta()
        {
            return View(new Venta());
        }

        [HttpPost]
        public ActionResult ActionVenta(Venta venta) {
            ViewBag.descuento = venta.Descuento();
            ViewBag.neto = venta.Neto();
            return View(venta);
        }
    }
}
