using Agentes.Domain.Exceptions.Pyramid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agentes.Domain.Models
{
    public class Pyramid
    {
        public string pyramidString { get; set; }

        /// <summary>
        /// Validación de si la entrada en un número entero
        /// </summary>
        /// <param name="str"></param>
        /// <returns>true si la entrada es un número entero</returns>
        /// <exception cref="NotIntNumber">El dato de entrada no es un número entero</exception>
        public bool IsIntNumber(string str)
        {
            try
            {
                int n = int.Parse(str);
            }
            catch (Exception)
            {
                throw new NotIntNumber("El dato de entrada no es un número entero");
            }
            return true;
        }

        /// <summary>
        /// Validación si el entero es mayor a 99
        /// </summary>
        /// <param name="str"></param>
        /// <returns>true si el número no es mayor a 99</returns>
        /// <exception cref="InputGraterThan99">El número es mayor a 99</exception>
        public bool NotIsGreaterThan99(int n)
        {
            if (n >= 100)
            {
                throw new InputGraterThan99("El número es mayor a 99");
            }
            return true;
        }

        /// <summary>
        /// Validación si el número es menor a 1
        /// </summary>
        /// <param name="n"></param>
        /// <returns>true si el número no es menor a 1</returns>
        /// <exception cref="InputLessThan1"></exception>
        public bool NotIsLessThan1(int n)
        {
            if (!(n > 0))
            {
                throw new InputLessThan1("El número es menor a 1");
            }
            return true;
        }
    }
}
