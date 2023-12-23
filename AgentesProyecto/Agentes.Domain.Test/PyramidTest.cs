using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agentes.Domain.Exceptions.Pyramid;
using Agentes.Domain.Models;

namespace Agentes.Domain.Test
{
    [TestClass]
    public class PyramidTest
    {
        [TestMethod]
        public void SendNumbetToIsIntNumberTest()
        {
            string str = "45";
            bool expected = true;
            Pyramid pyramid = new Pyramid();

            //Act
            bool result = pyramid.IsIntNumber(str);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void SendNotNumberToIsNumberTest()
        {
            string str = "no_number";
            Pyramid pyramid1 = new Pyramid();

            //Act and Assert
            Assert.ThrowsException<NotIntNumber>(()=> pyramid1.IsIntNumber(str));
        }

        [TestMethod]
        public void IsLessThan1Test()
        {            
            bool expected = true;
            Pyramid pyramid1 = new Pyramid();

            // Try a range of values.
            for (int i = 1; i > 100; i++)
            {
                OneValueTest(pyramid1, i, expected);
            }
        }

        public void OneValueTest(Pyramid pyramid1, int number, bool expectedResult)
        {
            //Act
            bool result = pyramid1.NotIsLessThan1(number);
            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void NotIsLessThan1Test()
        {
            Pyramid pyramid1 = new Pyramid();

            // Try a range of values.
            for (int i = 0; i < -100; i--)
            {
                OneValueTest2(pyramid1, i);
            }
        }

        public void OneValueTest2(Pyramid pyramid, int number)
        {
            //Act and Assert
            Assert.ThrowsException<InputLessThan1>(() => pyramid.NotIsLessThan1(number));
        }

        [TestMethod]
        public void NotIsGreaterThan99Test()
        {
            bool expected = true;
            Pyramid pyramid1 = new Pyramid();
            // Try a range of values.
            for (int i = 0; i < 100; i++)
            {
                OneValueTest3(pyramid1, i, expected);
            }
        }
        public void OneValueTest3(Pyramid pyramid1, int number, bool expectedResult)
        {
            //Act
            bool result = pyramid1.NotIsGreaterThan99(number);
            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void IsGreaterThan99Test()
        {
            Pyramid pyramid = new Pyramid();

            for(int i = 100; i < 199; i++)
            {
                OneValueTest4(pyramid, i);
            }
        }

        public void OneValueTest4(Pyramid pyramid, int number)
        {
            //Act and Assert
            Assert.ThrowsException<InputGraterThan99>(() => pyramid.NotIsGreaterThan99(number));
        }
    }
}
