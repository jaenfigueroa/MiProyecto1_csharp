using MiProyecto1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiProyecto1.Controllers
{
    public class TransporteController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Actionventa() {
            return View(new Transporte());
        }

        [HttpPost]
        public ActionResult Actionventa(Transporte transporte) {
            ViewBag.costo = transporte.Costo().ToString("####.#0");
            ViewBag.seguro = transporte.Seguro().ToString("####.#0");
            ViewBag.monto = transporte.Monto().ToString("####.#0");
            ViewBag.igv = transporte.IGV().ToString("####.#0");
            ViewBag.total = transporte.MontoTotal().ToString("####.#0");

            return View(transporte);
        }
    }
}