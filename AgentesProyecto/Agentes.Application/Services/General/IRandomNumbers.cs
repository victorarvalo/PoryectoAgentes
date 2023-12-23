using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agentes.Application.Services.General
{
    internal interface IRandomNumbers
    {
        public List<Double> CreateNumbers();
        public List<Double> CreateNumbers(int quantity);
    }
}
