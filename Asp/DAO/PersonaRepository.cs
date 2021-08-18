using Asp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Asp.DAO
{
    public class PersonaRepository
    {
        public List<ClsPersona> ObtenerPersona() {
            return new List<ClsPersona>()
            {
                new ClsPersona()
                {
                    Id= 1,
                    Nombre="Luis"
                },
                new ClsPersona()
                {
                    Id=2,
                    Nombre = "Jhonatan"
                },
                new ClsPersona(){
                    Id=3,
                    Nombre = "Jose"
                }

            };
        }
    }
}