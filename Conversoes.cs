using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Calculos.Aritmetica;

namespace Calculos
{
    /// <summary>
    /// Implementa operações de conversão
    /// </summary>
    internal static class Conversoes
    {
        /// <summary>
        /// Tipo de conversão de temperaturaa executar.
        /// </summary>
        public enum Conversaotemperatura
        {
            Nulo = 0,
            CelsiusFahrenheit,
            FahrenheitCelsius
        }
        /// <summary>
        /// Tipo de conversão de distâncias.
        /// </summary>
        public enum ConversaoDistancia
        {
            Nulo = 0,
            MetrosMilhas,
            MilhasMetros
        }
        /// <summary>
        /// Conversão de temperaturas.
        /// </summary>
        /// <param name="conversao"> A conversão a efetuar</param>
        /// <param name="temperatura">A temperatura a converter</param>
        /// <returns>Retona o resultado da conversão</returns>
        public static double ConverterTemperatura(Conversaotemperatura conversao, double temperatura)
        {
            if (conversao == Conversaotemperatura.CelsiusFahrenheit)
            {
            return (temperatura * 1.8000 + 32);
            }
            else if (conversao == Conversaotemperatura.FahrenheitCelsius)
            {
            return ((temperatura - 32) / 1.8000);
            }
            return -1;
         }

        /// <summary>
        /// Conversão de distâncias.
        /// </summary>
        /// <param name="conversao"> A conversão a efetuar</param>
        /// <param name="temperatura">A distância a converter</param>
        /// <returns>Retona o resultado da conversão da distância</returns>
        public static double ConverterDistancias (ConversaoDistancia conversao, double distancia)
        {
            if (conversao == ConversaoDistancia.MetrosMilhas)
            {
                return (distancia * 0.000621);
            }
            else if (conversao == ConversaoDistancia.MilhasMetros)
            {
                return distancia * 1609.344;
            }
            return -1;
        }
    }
}
