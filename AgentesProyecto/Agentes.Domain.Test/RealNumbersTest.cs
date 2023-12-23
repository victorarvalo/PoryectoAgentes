using Agentes.Domain.Models;
using Agentes.Domain.Exceptions.RealNumbers;
namespace Agentes.Domain.Test
{
    [TestClass]
    public class RealNumbersTest
    {
        [TestMethod]
        public void StringListWithOnlyNumbersTest()
        {
            List<string> numberList = new List<string>{"1","2","3"};
            bool expected = true;
            RealNumbers realNumbers = new RealNumbers();

            //Act
            bool result = realNumbers.AreOnlyNumbers(numberList);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void StringListWithoutOnlyNumbersTest()
        {
            List<string> numberList = new List<string> { "1", "2!", "3", "4" };
            RealNumbers realNumbers = new RealNumbers();

            //Act and Assert
            Assert.ThrowsException<OnlyNumberInList>(()=>realNumbers.AreOnlyNumbers(numberList));
        }

        [TestMethod]
        public void SendEmptyList()
        {
            List<string> numberList = new List<string> ();
            RealNumbers realNumbers = new RealNumbers();

            //Act and Assert
            Assert.ThrowsException<EmptyList>(() => realNumbers.EmptyList(numberList));
        }

        [TestMethod]
        public void SendNoEmptyList()
        {
            List<string> numberList = new List<string> { "1", "2", "3" };
            bool expected = false;
            RealNumbers realNumbers = new RealNumbers();

            //Act
            bool result = realNumbers.EmptyList(numberList); 
            
            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
