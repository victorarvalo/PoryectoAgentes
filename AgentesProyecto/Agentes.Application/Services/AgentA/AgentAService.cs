using Agentes.Application.Services.Funcionality1;
using Agentes.Application.Services.Funcionality2;
using Agentes.Domain.Exceptions.RealNumbers;
using Agentes.Domain.Exceptions.Pyramid;

namespace Agentes.Application.Services.AgentA
{
    public class AgentAService : IFuncionality1, IFuncionality2
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
        /// <returns>Promedio de los números</returns>
        public Double getMedia(List<Double> values)
        {
            return values.Sum(x => x) / values.Count;
        }


        /// <summary>
        /// Programación de funcionalidad 2
        /// </summary>
        /// <param name="str"></param>
        /// <returns>String con la escalera</returns>
        public string GetFuncionality2(string str)
        {
            Domain.Models.Pyramid pyramid = new Domain.Models.Pyramid();
            try
            {
                if (pyramid.IsIntNumber(str))
                {
                    int value = int.Parse(str);
                    if (pyramid.NotIsGreaterThan99(value))
                    {
                        if (pyramid.NotIsLessThan1(value))
                        {
                            pyramid.pyramidString = getStaircase(value);
                            return pyramid.pyramidString;
                        }
                    }
                }
            }
            catch(NotIntNumber nit)
            {
                throw new Exception("!400", nit);
            }
            catch(InputGraterThan99 igt99)
            {
                throw new Exception("!400", igt99);
            }
            catch(InputLessThan1 ilt1)
            {
                throw new Exception("!400", ilt1);
            }
            catch (Exception ex)
            {
                throw new Exception("!500", ex);
            }
            return string.Empty;
        }

        /// <summary>
        /// Obtiene el string de la escalera
        /// </summary>
        /// <param name="number"></param>
        /// <returns>String con la escalera</returns>
        public string getStaircase(int number)
        {
            
            string stair = String.Empty;
            for(int x = (number - 1); x >= 0 ; x--)
            {
                stair += AddSpaces(x);
                stair += AddHash(number - x);
                stair += "\n\r";
            }
            return stair;
        }

        /// <summary>
        /// Agrega la cantidad de espacios del parametro de entrada
        /// </summary>
        /// <param name="n"></param>
        /// <returns>string con espacios</returns>
        private string AddSpaces(int n)
        {
            string space = " ";
            string output = string.Empty;
            for(int x = 0; x < n;x++)
            {
                output += space;
            }
            return output;
        }

        /// <summary>
        /// Agrega la cantidad de hash del parametro de entrada
        /// </summary>
        /// <param name="n"></param>
        /// <returns>string con hash</returns>
        private string AddHash(int n)
        {
            string hash = "#";
            string output = string.Empty;
            for (int x = 0; x < n; x++)
            {
                output += hash;
            }
            return output;
        }
    }
}
