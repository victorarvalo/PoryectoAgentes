using Agentes.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agentes.Domain.Models
{
    public class RealNumbers
    {
        public List<Double> Values { get; }
        
        public RealNumbers() {  Values = new List<Double>(); }
        /// <summary>
        /// Se obtiene la lista de números
        /// esta función se debe llamar despues de la validación con el metodo AreOnluNumbers
        /// se coloca try catch como precaución
        /// </summary>
        /// <param name="values">lista de string para obtener la lista de números</param>
        public void GetNumbers(List<string> svalues)
        {
            try
            {
                foreach (var svalue in svalues)
                {
                    var value = Double.Parse(svalue.Replace(",", "."));
                    Values.Add(value);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
        public bool AreOnlyNumbers(List<string> numberList)
        {
            foreach (string value in numberList) 
            {
                try
                {
                    double.Parse(value);
                }catch (Exception)
                {
                    throw new OnlyNumberInList("La lista de números tiene valores erroneos");
                }
            }
            return true;
        }

        public bool EmptyList(List<string> list)
        {
            if (!list.Any())
            {
                throw new EmptyList("La lista de números esta vacia");
            }
            return false;
        }
    }
}
