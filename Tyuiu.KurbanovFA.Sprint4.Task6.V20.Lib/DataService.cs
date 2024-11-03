using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KurbanovFA.Sprint4.Task6.V20.Lib
{
    public class DataService : ISprint4Task6V20
    {
        public string[] Calculate(string[] array)
        {
            int nullCount = 0;
            string[] result = new string[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length < 10)
                {
                    result[i] = array[i];
                    nullCount++;
                }
            }
            string[] res = new string[nullCount];
            res = result.Where(word => word != null).ToArray();
            return res;
            /*result.Where(c => c != null).ToArray();*/
        }
    }
}
