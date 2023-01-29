using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace AntonellaCortes_EjercicioCF1.Models
{
    public class Burger
    {
        private BurgerSettings _settings;

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

        public decimal Revenue { get; set; }

        public bool IsPrivate
        {
            get => _settings.IsPrivate;
            set => _settings.IsPrivate = value;
        }

        public bool HideRevenue // si no está disponible
        {
            get => _settings.HideRevenue;
            set => _settings.HideRevenue = value;
        }

        public Burger()
        {
            _settings = new BurgerSettings();
        }

        public void SetSettings(BurgerSettings settings)
        {
            _settings = settings;
        }

        public Burger Clone()
        {
            return new Burger()
            {
                Name = Name,
                WithCheese = WithCheese,
                WithTomatoes = WithTomatoes,
                Price = Price,
                Revenue = Revenue,
                _settings = _settings.Clone()
            };
        }

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
