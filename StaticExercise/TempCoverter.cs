using System;
using System.Collections.Generic;
using System.Text;

namespace StaticExercise
{
    public static class TempCoverter
    {
        public static double FarenheitToCelcius (double farenheit)
            {
            var celcius = (farenheit - 32) / (5d/9d);
            return celcius;

            }
        public static double CelciusToFarentheit (double celcius)
        {
            return (celcius * (9.0/5.0) + 32);
        }
    }
}
