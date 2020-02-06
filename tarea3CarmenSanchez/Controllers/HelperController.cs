using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using tarea3CarmenSanchez.Models;

namespace tarea3CarmenSanchez.Controllers
{
    public class HelperController : Controller
    {
        // GET: Helper
        public ActionResult Formulario()
        {
            return View();
        
        }


        [HttpPost]
        public ActionResult Datos(Persona per, HttpPostedFileBase foto)
        {
            if (ModelState.IsValid)
            {
                string nombre = foto.FileName;
                foto.SaveAs(Server.MapPath("/img/" + nombre));
                ViewBag.picture = nombre;

                return View(per);

            }
            else
            {
                return View("Formulario");
            }

        }
    }
}