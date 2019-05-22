using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tempconverter
{
    //Program to convert from Celsius degrees to Kelvin and Fahrenheit
    class Program
    {
        static void Main(string[] args)
        {
            
                Console.Write("Enter the celsius: ");
                int celsius = int.Parse(Console.ReadLine());

            Console.WriteLine("Kelvin = {0}", celsius + 273); // 1°C + 273.15 = 274.15K

            Console.WriteLine("Fahrenheit = {0}", celsius * 18 / 10 + 32); //(1°C × 9/5) + 32 = 33.8°F



        }
    }
}
