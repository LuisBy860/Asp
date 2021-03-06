using Asp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Asp.Controllers
{
    public class EmpleadoController : Controller
    {
        // GET: Empleado
        public ActionResult Empleado() //este es el controller
        {

            using (EmpleadoEntities bd = new EmpleadoEntities())
            {

                var ListadoEmpleado = bd.Empleado.ToList();

                return View(ListadoEmpleado);
            }
        }
        public ActionResult save(String id, string nombre, string direccion )
        {
            using (EmpleadoEntities bd = new EmpleadoEntities())
            {
                if (id == null|| id.Equals("") || id == "0")
                {


                    Empleado emp = new Empleado();
                    emp.Nombre = nombre;
                    emp.Direccion = direccion;
                    bd.Empleado.Add(emp); //este es como la funcion agregar de un crud 
                    bd.SaveChanges();//con esto la base de datos reconoce los datos ingresados 
                }
                else
                {
                    int idupdate = Convert.ToInt32(id);
                    //estrutura de exprecion lambda
                    Empleado editar = bd.Empleado.Where(e => e.IdEmpleado == idupdate).FirstOrDefault();
                    editar.Nombre = nombre;
                    bd.SaveChanges();
                }


                return Redirect("/Empleado/Empleado"); //si hago un rediccionamiento  cuando colocamos un viewbag no lo va cargar
            }



        }
        public ActionResult Registro(String id,String nombre)
        {
            ViewBag.idenviado = id;


            
            ViewBag.EnviandoDatosRegistro = nombre;
            return View();
           
          
        }
        public ActionResult Delete(int id)
        {

            using (EmpleadoEntities bd = new EmpleadoEntities())
            {
                Empleado eliminardatos = bd.Empleado.Where(x => x.IdEmpleado == id).FirstOrDefault(); //EF,expreciones lamba y linq(lenguaje de consulta a colecciones de datos )  
                bd.Empleado.Remove(eliminardatos); //elimina el dato y guardamos con savechanges
                bd.SaveChanges();  
            return Redirect("/Empleado/Empleado");
            }
        }
    } 
}

    
