using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aplicação Cálculos");

            Console.WriteLine($"4 + 2={Aritmetica.Somar(4,2)}");
            Console.WriteLine($"4 - 2={Aritmetica.Subtrair(4, 2)}");

            double t1 = Conversoes.ConverterTemperatura(Conversoes.Conversaotemperatura.CelsiusFahrenheit, 36);
            double t2 = Conversoes.ConverterTemperatura(Conversoes.Conversaotemperatura.FahrenheitCelsius, 100);
            
            Console.WriteLine($"36º Celsius = {t1}º Fahreneit");
            Console.WriteLine($"100º Fahreneit = {t2}º Celsius");
            
            Console.ReadKey();
        }
    }
}
