using System;
using System.Collections.Generic;
using System.Text;

namespace AntonellaCortes_EjercicioCF1.Models
{
    public class BurgerSettings
    {
        public bool IsPrivate { get; set; }
        public bool HideRevenue { get; set; }

        public BurgerSettings Clone()
        {
            return new BurgerSettings()
            {
                IsPrivate = IsPrivate,
                HideRevenue = HideRevenue
            };
        }
    }
}
