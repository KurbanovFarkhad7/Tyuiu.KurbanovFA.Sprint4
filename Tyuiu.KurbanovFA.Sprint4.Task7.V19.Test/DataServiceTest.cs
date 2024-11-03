using Tyuiu.KurbanovFA.Sprint4.Task7.V19.Lib;

namespace Tyuiu.KurbanovFA.Sprint4.Task7.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string input = "90817264";
            int res = ds.Calculate(4,2, input);
            int wait = 3;
            Assert.AreEqual(wait, res);
        }
    }
}