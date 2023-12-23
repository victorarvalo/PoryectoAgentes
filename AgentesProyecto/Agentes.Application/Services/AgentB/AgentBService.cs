using Agentes.Application.Services.Funcionality1;
using Agentes.Domain.Exceptions.RealNumbers;
using domainExceptions = Agentes.Domain.Exceptions;

namespace Agentes.Application.Services.AgentB
{
    public class AgentBService : IFuncionality1
    {
        /// <summary>
        /// Programación de funcionalidad 1
        /// </summary>
        /// <param name="args"></param>
        /// <returns>La media armonica de los números o la excepción</returns>
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
            catch (EmptyList el)
            {
                throw new Exception("!400", el);
            }
            catch (OnlyNumberInList onil)
            {
                throw new Exception("!400", onil);
            }
            catch (Exception ex)
            {
                throw new Exception("!500", ex);
            }
            return string.Empty;
        }
        /// <summary>
        /// Se obtiene el promedio de los números obtenidos
        /// </summary>
        /// <param name="values"></param>
        /// <returns>La media armonica de los números</returns>
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
