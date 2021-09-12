using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Asp.Models.ViewModels
{
    public class PersonaViewModel
    {
        [Display(Name="Monto")]
        [Required(ErrorMessage ="debe de llenar este campo")]
        public int Monto { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "debe de llenar este campo")]
        public string Nombre { get; set; }


    }
}