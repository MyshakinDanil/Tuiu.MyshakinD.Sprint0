using Tyuiu.MyshakinD.Sprint0.Task2.V0.lib;

namespace Tyuiu.MyshakinD.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "�����";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("������ �����", res);
        }
    }
}