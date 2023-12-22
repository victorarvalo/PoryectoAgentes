using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agentes.Domain.Exceptions
{
    public class OnlyNumberInList : Exception
    {
        public OnlyNumberInList(string message) : base(message) { }
    }
}
