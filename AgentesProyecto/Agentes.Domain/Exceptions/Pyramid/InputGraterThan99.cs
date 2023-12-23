using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agentes.Domain.Exceptions.Pyramid
{
    public class InputGraterThan99 : Exception
    {
        public InputGraterThan99(string message) : base(message) { }
    }
}
