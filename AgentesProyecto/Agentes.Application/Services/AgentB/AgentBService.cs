using Agentes.Application.Services.Funcionality1;
using domainExceptions = Agentes.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agentes.Application.Services.AgentB
{
    public class AgentBService : IFuncionality1
    {
        public String GetFuncionality1(List<string> args)
        {
            Domain.Models.RealNumbers realNumbers = new Domain.Models.RealNumbers();
            try
            {
                //Validación de lista vacia
                if (!realNumbers.EmptyList(args))
                {
                    //validación de solo numeros reales en la lista
                    if (realNumbers.AreOnlyNumbers(args))
                    {
                        realNumbers.GetNumbers(args);
                        return getMedia(realNumbers.Values).ToString();
                    }
                }
            }
            catch (domainExceptions.EmptyList el)
            {
                throw new Exception("!400", el);
            }
            catch (domainExceptions.OnlyNumberInList onil)
            {
                throw new Exception("!400", onil);
            }
            catch (Exception ex)
            {
                throw new Exception("!500", ex);
            }
            return string.Empty;
        }
        public double getMedia(List<double> values)
        {
            List<Double> proportionalInverse = new List<double>();
            foreach(double value in values)
            {
                proportionalInverse.Add(1 / value);
            }
            return ((proportionalInverse.Count) / proportionalInverse.Sum(x => x));
        }
    }
}
