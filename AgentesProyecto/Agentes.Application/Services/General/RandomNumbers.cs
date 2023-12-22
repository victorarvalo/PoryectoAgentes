using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agentes.Application.Services.General
{
    public class RandomNumbers : IRandomNumbers
    {
        private Random random = new Random();

        /// <summary>
        /// Create 10 random Doubles
        /// </summary>
        /// <returns>List<double></returns>
        public List<double> CreateNumbers()
        {
            var numbers = new List<double>();
            for(int x = 0; x < 10; x++)
            {
                numbers.Add(random.NextDouble());
            }
            return numbers;
        }

        /// <summary>
        /// Create a list of Double with the quantity
        /// </summary>
        /// <param name="quantity">quentity of Doubles to return</param>
        /// <returns></returns>
        public List<double> CreateNumbers(int quantity)
        {
            if(quantity == 0 && quantity < 0) {  return new List<double>(); }
            var numbers = new List<double>();
            for (int x = 0; x < quantity; x++)
            {
                numbers.Add(random.NextDouble());
            }
            return numbers;
        }
    }
}
