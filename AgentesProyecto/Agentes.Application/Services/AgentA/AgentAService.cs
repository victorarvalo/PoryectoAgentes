using Agentes.Application.Services.Funcionality1;
using domainExceptions = Agentes.Domain.Exceptions;

namespace Agentes.Application.Services.AgentA
{
    public class AgentAService : IFuncionality1
    {
        /// <summary>
        /// Programación de funcionalidad 1
        /// </summary>
        /// <param name="args"></param>
        /// <returns>El promedio de los números o la excepción</returns>
        public String GetFuncionality1(List<string> args)
        {
            Domain.Models.RealNumbers realNumbers = new Domain.Models.RealNumbers();
            try
            {
                //Validación de lista vacia
                if(!realNumbers.EmptyList(args))
                {
                    //validación de solo numeros reales en la lista
                    if(realNumbers.AreOnlyNumbers(args))
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


        /// <summary>
        /// Se obtiene el promedio de los números obtenidos
        /// </summary>
        /// <param name="values"></param>
        /// <returns>Promedio de los números</returns>
        public Double getMedia(List<Double> values)
        {
            return values.Sum(x => x) / values.Count;
        }
    }
}
