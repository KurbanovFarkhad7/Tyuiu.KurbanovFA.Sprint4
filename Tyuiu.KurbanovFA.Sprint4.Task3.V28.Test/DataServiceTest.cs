using Tyuiu.KurbanovFA.Sprint4.Task3.V28.Lib;

namespace Tyuiu.KurbanovFA.Sprint4.Task3.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int[,] array = new int[,]
            {
                {1,2,3,4,5 },
                {6,7,8,9,10 },
                {11,12,13,14,15 },
                {16,17,18,19,20 },
                {21,22,23,24,25 },
            };
            int res = ds.Calculate(array);
            int wait = 16;
            Assert.AreEqual(wait, res);
        }
    }
}