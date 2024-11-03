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
            string[] array = { "����������", "������", "�����", "��������", "���������", "�������", "����������" };
            string[] res = ds.Calculate(array);
            string[] wait = {"������", "�����", "��������", "���������", "�������"};
            CollectionAssert.AreEqual(wait, res);
        }
    }
}