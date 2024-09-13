using System.Security.Cryptography.X509Certificates;
using Tyuiu.MyshakinD.Sprint0.Task6.V0.Lib;
namespace Tyuiu.MyshakinD.Sprint0.Task6.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ChekedAdditionArray()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.AdditionArray(numbers);
            Assert.AreEqual(15, res);
        }

        [TestMethod]
        public void ChekedSubstractionArray()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.SubstractionArray(numbers);
            Assert.AreEqual(-15, res);
        }

        [TestMethod]
        public void ChekedMultiplicationnArray()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.MultiplicationArray(numbers);
            Assert.AreEqual(120, res);
        }
    }
}