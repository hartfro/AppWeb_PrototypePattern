using System;
using System.Collections.Generic;
using System.Text;

namespace AntonellaCortes_EjercicioCF1.Models
{
    public class BurgerSettingsPrototypeRegistry
    {
        private readonly BurgerSettings _defaultBurgerSettings;
        private readonly BurgerSettings _secureBurgerSettings;

        public BurgerSettingsPrototypeRegistry(BurgerSettings defaultBurgerSettings, BurgerSettings secureBurgerSettings)
        {
            _defaultBurgerSettings = defaultBurgerSettings;
            _secureBurgerSettings = secureBurgerSettings;
        }

        public BurgerSettings CreateDefaultBurgerSettings()
        {
            return _defaultBurgerSettings.Clone();
        }

        public BurgerSettings CreateSecureBurgerSettings()
        {
            return _secureBurgerSettings.Clone();
        }
    }
}
