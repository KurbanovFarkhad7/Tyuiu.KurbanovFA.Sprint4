using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KurbanovFA.Sprint4.Task4.V9.Lib
{
    public class DataService : ISprint4Task4V9
    {
        public int Calculate(int[,] matrix)
        {
            int result = 0;
            for (int y = 0; y < matrix.GetLength(0); y++)
            {
                for (int x = 0; x < matrix.GetLength(1); x++)
                {
                    if (matrix[y, x] % 2 == 0)
                    {
                        result += matrix[y, x];
                    }
                }
            }
            return result;
        }
    }
}
