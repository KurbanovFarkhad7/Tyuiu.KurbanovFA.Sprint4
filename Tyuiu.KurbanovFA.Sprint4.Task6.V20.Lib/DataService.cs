﻿using tyuiu.cources.programming.interfaces.Sprint4;

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
                    /*nullCount++;*/ //если нужно будет создать массив с четким кол-вом нужных ячеек
                }
            }
            return result.Where(word => word != null).ToArray();
        }
    }
}
