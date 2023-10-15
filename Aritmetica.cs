using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    /// <summary>
    /// Implementa operações aritméticas
    /// </summary>
    internal static class Aritmetica
    {
        /// <summary>
        /// Tipo de conversão de temperaturaa executar.
        /// </summary>
        public enum Conversaotemperatura
        {
            Nulo =0,
            CelsiusFahrenheit,
            FahrenheitCelsius
        }
        /// <summary>
        /// Operação Soma.
        /// </summary>
        /// <returns>Retorna a soma de dois números.</returns>

        public static int Somar (int x, int y)
        {
            return x + y;
        }
        /// <summary>
        /// Operação de Subtração.
        /// </summary>
        /// <returns>Retorna a diferença entre dois números.</returns>
        public static int Subtrair (int x, int y)
        {
            return x - y;
        }

        public static double ConverterTemperatura(Conversaotemperatura conversao, double temperatura)
        {
            if (conversao==Conversaotemperatura.CelsiusFahrenheit)
            {
                return (temperatura * 1.8000 + 32);
            }
            else if (conversao == Conversaotemperatura.FahrenheitCelsius)
            {
                return ((temperatura - 32) / 1.8000);
            }
            return -1;
        }

    }
}
