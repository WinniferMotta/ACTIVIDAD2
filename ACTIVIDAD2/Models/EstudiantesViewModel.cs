using Microsoft.AspNetCore.Mvc.Rendering; 
using System.Collections.Generic; 
using System.ComponentModel.DataAnnotations;

namespace ACTIVIDAD2.Models
{
    public class EstudiantesViewModels
    {

        [Required(ErrorMessage = "La matrícula es obligatoria.")]
        public string Matricula { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El apellido es obligatorio.")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "La carrera es obligatoria.")]
        public string Carrera { get; set; }

        [Required(ErrorMessage = "El turno es obligatorio.")]
        public string Turno { get; set; }

        [Required(ErrorMessage = "El tipo de ingreso es obligatorio.")]
        public string TipoIngreso { get; set; }

        public bool EstaBecado { get; set; }

       
        public int? PorcentajeBeca { get; set; }

      
        public List<SelectListItem> OpcionesCarrera { get; set; }
        public List<SelectListItem> OpcionesTurno { get; set; }
        public List<SelectListItem> OpcionesTipoIngreso { get; set; }

        
        public EstudiantesViewModels()
        {
            OpcionesCarrera = new List<SelectListItem>
            {
                new SelectListItem { Value = "Informática", Text = "Informática" },
                new SelectListItem { Value = "Contabilidad", Text = "Contabilidad" },
                new SelectListItem { Value = "Administración", Text = "Administración" },
                new SelectListItem { Value = "Derecho", Text = "Derecho" },
                new SelectListItem { Value = "Medicina", Text = "Medicina" }
            };

            OpcionesTurno = new List<SelectListItem>
            {
                new SelectListItem { Value = "Matutino", Text = "Matutino" },
                new SelectListItem { Value = "Vespertino", Text = "Vespertino" },
                new SelectListItem { Value = "Nocturno", Text = "Nocturno" }
            };

            OpcionesTipoIngreso = new List<SelectListItem>
            {
                new SelectListItem { Value = "Nuevo Ingreso", Text = "Nuevo Ingreso" },
                new SelectListItem { Value = "Reingreso", Text = "Reingreso" },
                new SelectListItem { Value = "Transferencia", Text = "Transferencia" }
            };
        }
    }
}
