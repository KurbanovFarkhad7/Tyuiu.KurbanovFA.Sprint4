using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KurbanovFA.Sprint4.Task3.V28.Lib
{
    public class DataService : ISprint4Task3V28
    {
        public int Calculate(int[,] array)
        {
            int[] result = new int[array.GetLength(1)];
            for (int y = 0;  y < array.GetLength(0); y++)
            {
                for (int x = 0; x < array.GetLength(1); x++)
                {
                    if (y == 3)
                    {
                        result[x] = array[y, x];
                    }
                }
            }
            return result.Min();
        }
    }
}
