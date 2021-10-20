using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PC03_Simulacro.Models
{
    public class SolicitudCompra
    {
        public int Id {get; set;}

        [Required]
        public string NombreProducto {get; set;}
         [Required]
        public string Foto{get;set;}
         [Required]
        public string Descripcion{get;set;}
         [Required]
        public int Precio {get; set;}
         [Required]
        public int Celular {get; set;}
         [Required]
        public string LugarCompra{get;set;}
         [Required]
        public string NombreComprador{get;set;}
         [Required]
        public string Categoria{get;set;}
        public DateTime Fecha{get;set;}
        public SolicitudCompra(){
            DateTime limitDate = DateTime.Today.AddDays(-5);
            Fecha = limitDate;       
            var Dia = Fecha.Day;
            var Mes = Fecha.Month;
            var Año = Fecha.Year;
        }
    }
}