using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agentes.Domain.Exceptions
{
    public class EmptyList : Exception
    {
        public EmptyList(string message) : base(message) { }
    }
}
