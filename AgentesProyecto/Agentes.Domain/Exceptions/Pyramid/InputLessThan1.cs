using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agentes.Domain.Exceptions.Pyramid
{
    public class InputLessThan1 : Exception
    { 
        public InputLessThan1(string message) : base(message) { }
    }
}
