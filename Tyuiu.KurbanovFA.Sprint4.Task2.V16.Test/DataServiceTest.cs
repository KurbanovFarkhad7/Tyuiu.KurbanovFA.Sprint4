using Tyuiu.KurbanovFA.Sprint4.Task2.V16.Lib;

namespace Tyuiu.KurbanovFA.Sprint4.Task2.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int[] array = { 1, 2, 3 };
            int res = ds.Calculate(array);
            int wait = 3;
            Assert.AreEqual(wait, res);
        }
    }
}