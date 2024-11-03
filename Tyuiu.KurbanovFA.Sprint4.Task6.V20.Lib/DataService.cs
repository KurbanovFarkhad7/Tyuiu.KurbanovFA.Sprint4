using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KurbanovFA.Sprint4.Task6.V20.Lib
{
    public class DataService : ISprint4Task6V20
    {
        public string[] Calculate(string[] array)
        {
            string[] result = { };
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length < 10)
                {
                    result[i] = array[i];
                }
            }
            return result;
        }
    }
}
