using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Asp.DAO;
using Asp.Models;
using Asp.Models.ViewModels;

namespace Asp.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Humano()
        {

            var persona = new ClsPersona { Nombre="Luis"};

            return View(persona);
        }
        public ActionResult VistaListadoPersona(String nombre)
        {

            PersonaRepository persona = new PersonaRepository();
            ViewBag.EnviadoNombre = nombre;

            return View(persona.ObtenerPersona());
        }

        public ActionResult PersonaViewModel()
        {

            return View();
        }

        public ActionResult PersonaViewModels(PersonaViewModel persona)
        {

            if (!ModelState.IsValid)
            {


                return View("ErrorViewModel");
            }

            return Redirect("CajeroViewModel");
        }


    }
}