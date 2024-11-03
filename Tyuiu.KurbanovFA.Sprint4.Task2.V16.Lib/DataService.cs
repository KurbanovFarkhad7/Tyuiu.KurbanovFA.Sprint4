using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KurbanovFA.Sprint4.Task2.V16.Lib
{
    public class DataService : ISprint4Task2V16
    {
        public int Calculate(int[] array)
        {
            int result = 1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    continue;
                }
                else { result *= array[i]; }
            }
            return result;
        }
    }
}
