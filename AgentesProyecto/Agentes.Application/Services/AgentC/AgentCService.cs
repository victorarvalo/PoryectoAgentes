using Agentes.Application.Services.Funcionality1;
using Agentes.Application.Services.Funcionality2;
using Agentes.Domain.Exceptions.Pyramid;
using Agentes.Domain.Exceptions.RealNumbers;
using System.Collections.Specialized;
using domainExceptions = Agentes.Domain.Exceptions;

namespace Agentes.Application.Services.AgentC
{
    public class AgentCService : IFuncionality1, IFuncionality2
    {
        /// <summary>
        /// Programación de funcionalidad 1
        /// </summary>
        /// <param name="args"></param>
        /// <returns>La media de los números o la excepción</returns>
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
        /// <returns>La media de los números</returns>
        public double getMedia(List<double> values)
        {
            values.Sort();
            //validación de cantidad de pares
            if(values.Count % 2 == 0)
            {
                int midPosition = values.Count / 2;
                return ((values[midPosition - 1] + values[midPosition]) / 2);
            }
            else
            {
                int midPosition = values.Count / 2;
                return (values[midPosition]);
            }
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
            catch (NotIntNumber nit)
            {
                throw new Exception("!400", nit);
            }
            catch (InputGraterThan99 igt99)
            {
                throw new Exception("!400", igt99);
            }
            catch (InputLessThan1 ilt1)
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
            //Cantidad de # en la base de la escalera
            int hashbase = (number + ((number-1)*2));
            //Contador de altura
            int hight = 1;
            //Arreglo de lineas
            string[] stairLines = new string[((number * 2) - 1)];
            //obtenemos la linea central
            int center = stairLines.Length / 2;
            //llenamos la linea central
            stairLines[center] = AddHash(hashbase);
            for(int x = 0; x < number - 1; x++)
            {
                hight = x + 1;
                int actSpaces = hight;
                int actHash = hashbase - (hight * 2);
                stairLines[(center - hight)] = AddLine(actSpaces, actHash);
                stairLines[(center + hight)] = AddLine(actSpaces, actHash);
            }
            //creamos el string de salida
            foreach(string line in stairLines)
            {
                stair += line;
                stair += "\n\r";
            }
            return stair;
        }

        /// <summary>
        /// Agrega espacios y hash centrados
        /// </summary>
        /// <param name="spaces"></param>
        /// <param name="hash"></param>
        /// <returns></returns>
        private string AddLine(int spaces, int hash)
        {
            string output = string.Empty;
            output += AddSpaces(spaces);
            output += AddHash(hash);
            output += AddSpaces(spaces);
            return output;
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
            for (int x = 0; x < n; x++)
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
