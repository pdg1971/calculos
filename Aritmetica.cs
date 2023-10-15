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
    internal class Aritmetica
    {
        /// <summary>
        /// Operação Soma.
        /// </summary>
        /// <returns>Retorna a soma de dois números.</returns>

        public int Somar (int x, int y)
        {
            return x + y;
        }
        /// <summary>
        /// Operação de Subtração.
        /// </summary>
        /// <returns>Retorna a diferença entre dois números.</returns>
        public int Subtrair (int x, int y)
        {
            return x - y;
        }

    }
}
