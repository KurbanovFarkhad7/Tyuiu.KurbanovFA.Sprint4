using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KurbanovFA.Sprint4.Task7.V19.Lib
{
    public class DataService : ISprint4Task7V19
    {
        public int Calculate(int n, int m, string value)
        {
            int oddCount = 0;
            int[,] matrix = new int[n, m];
            for (int i = 0; i < value.Length; i++)
            {
                int num = int.Parse(value[i].ToString());
                matrix[i / 2, i % 2] = num;
                if (num % 2 != 0)
                {
                    oddCount++;
                }
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            return oddCount;
        }
    }
}
