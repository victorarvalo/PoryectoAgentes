using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agentes.Domain.Exceptions.Pyramid
{
    public class NotIntNumber : Exception
    {
        public NotIntNumber(string message) : base(message) { }
    }
}
