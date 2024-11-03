using Tyuiu.KurbanovFA.Sprint4.Task0.V19.Lib;

namespace Tyuiu.KurbanovFA.Sprint4.Task0.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int[] array = { 1, 2, 3 };
            int res = ds.GetMultOddArrEl(array);
            int wait = 3;
            Assert.AreEqual(wait, res);
        }
    }
}