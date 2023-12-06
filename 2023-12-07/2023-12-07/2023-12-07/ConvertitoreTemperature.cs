using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_12_07 {
    public class ConvertitoreTemperature {
        public static float CelsiusToFahreneit(float tempCelsius) {
            return ((tempCelsius * 9) / 5) + 32;
        }

        public static float FahreneitToCelsius(float tempFahreneit) {
            return ((tempFahreneit - 32) / 9) * 5;
        }

        public static float CelsiusToKelvin(float tempCelsius) {
            return tempCelsius + 273.15f;
        }

        public static float KelvinToCelsius(float tempKelvin) {
            return tempKelvin - 273.15f;
        }

        public static float KelvinToFahreneit(float tempKelvin) {
            return CelsiusToFahreneit(KelvinToCelsius(tempKelvin));
        }

        public static float FahreneitToKelvin(float tempFahreneit) {
            return CelsiusToKelvin(FahreneitToCelsius(tempFahreneit));
        }
    }
}
