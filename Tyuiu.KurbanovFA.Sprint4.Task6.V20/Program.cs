using Tyuiu.KurbanovFA.Sprint4.Task6.V20.Lib;

namespace Tyuiu.KurbanovFA.Sprint4.Task6.V20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Курбанов Ф.А. | РППб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнил: Курбанов Фархаджон Азамжанович | РППб-24-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных [Математика,Физика,Химия,                   *");
            Console.WriteLine("* Биология, География, История, Литература], используя класс Array,       *");
            Console.WriteLine("* выведите элементы массива, длина которых меньше 10 символов             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string[] array = ["Математика", "Физика", "Химия", "Биология", "География", "История", "Литература"];
            

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string[] result = ds.Calculate(array);
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}
