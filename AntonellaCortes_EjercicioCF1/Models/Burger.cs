using System.ComponentModel.DataAnnotations;

namespace AntonellaCortes_EjercicioCF1.Models
{
    public class Burger
    {
        // prop + tab -> automático
        // a nivel de clase, hay que decir cuál es el id
        // crear un atributo id
        public int Id { get; set; } // combo nombreClase+Id - primary key
        [Required]
        public String Name { get; set; }
        public bool WithCheese { get; set; }
        public bool WithTomatoes { get; set; }
        //[Range(0.01,9999.9)]
        [VerificarRango]
        public decimal Price { get; set; }

    }

    // nuevo data annotation
    public class VerificarRango : ValidationAttribute // validaciones
    {
        public override bool IsValid(object? valor)
        {
            decimal valor1 = (decimal)valor;
            if (valor1 < 2)
            {
               return false;
            } 
            else
            {
                return true;
            }
        }
    }
}
