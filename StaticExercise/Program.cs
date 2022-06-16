using System;

namespace StaticExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input farenheit degree to convert.");
            double farenheit = Convert.ToDouble(Console.ReadLine());
            double convertToCel= TempCoverter.FarenheitToCelcius(farenheit);

            Console.WriteLine($"{farenheit} degree farenheit equals to {convertToCel} degree celcius");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Input celcius degree to convert.");
            double celcius = Convert.ToDouble(Console.ReadLine());
            double convertToFar = TempCoverter.CelciusToFarentheit(celcius);
         
            Console.WriteLine($"{celcius} degree celcius equals to {convertToFar} degree farenheit.");
        }
    }
}
