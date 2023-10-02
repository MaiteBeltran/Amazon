using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Amazon.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Producto
        public ActionResult Index()
        {
            return View();
        }

        //public ActionResult Detalle(id)
        //{
        //    var producto = ObtenerDetalleProducto(id);

        //    return View(producto);
        //}

    }
}