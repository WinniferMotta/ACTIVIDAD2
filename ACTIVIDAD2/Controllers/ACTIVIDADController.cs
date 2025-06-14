using Microsoft.AspNetCore.Mvc; 
using ACTIVIDAD2.Models; 
using System.Collections.Generic; 
using System.Linq; 

namespace ACTIVIDAD2.Controllers
{
   
    public class ACTIVIDADController : Controller
    {
       
        private static List<EstudiantesViewModels> listaEstudiantes = new List<EstudiantesViewModels>();

        [HttpGet]
        public IActionResult Index()
        {
            
            return View(new EstudiantesViewModels());
        }

        
        [HttpPost]
        public IActionResult Registrar(EstudiantesViewModels model)
        {
          
            if (ModelState.IsValid)
            {
                
                listaEstudiantes.Add(model);
               
                return RedirectToAction("Lista");
            }
           
            return View("Index", model);
        }

      
        public IActionResult Lista()
        {
            
            return View(listaEstudiantes);
        }

        
        [HttpGet]
        public IActionResult Editar(string matricula)
        {
            var estudiante = listaEstudiantes.FirstOrDefault(e => e.Matricula == matricula);
            if (estudiante == null)
                return NotFound();

            return View(estudiante);
        }

      
        [HttpPost]
        public IActionResult Editar(EstudiantesViewModels model)
        {
          
            if (ModelState.IsValid)
            {
                
                var existente = listaEstudiantes.FirstOrDefault(e => e.Matricula == model.Matricula);
                
                if (existente != null)
                {
                    existente.Nombre = model.Nombre;
                    existente.Apellido = model.Apellido;
                    existente.Carrera = model.Carrera;
                    existente.Turno = model.Turno;
                    existente.TipoIngreso = model.TipoIngreso;
                    existente.EstaBecado = model.EstaBecado;
                    existente.PorcentajeBeca = model.PorcentajeBeca;
                }
              
                return RedirectToAction("Lista");
            }
            
            return View(model);
        }
    }
}
