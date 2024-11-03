using Tyuiu.KurbanovFA.Sprint4.Task6.V20.Lib;

namespace Tyuiu.KurbanovFA.Sprint4.Task6.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string[] array = { "Математика", "Физика", "Химия", "Биология", "География", "История", "Литература" };
            string[] res = ds.Calculate(array);
            string[] wait = {"Физика", "Химия", "Биология", "География", "История"};
            CollectionAssert.AreEqual(wait, res);
        }
    }
}