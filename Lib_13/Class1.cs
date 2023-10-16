using System;

namespace Lib_13
{
    public class CLasspr1
    {
        /// <summary>
        /// Функция генерирует рандомные числа, и когда встречаются 2 одинаковых подряд, производит вычисления
        /// </summary>
        /// <param name="ch">одинаковое число</param>
        /// <param name="zn">результат вычислений</param>
        public static void GenerateNumber(out string ch, out string zn)
        {
            Random rnd = new Random(); int X = rnd.Next(-5, 6); double a = X; int b = 0;
            for (int i = 0; i < 1;)//бесконечный цикл, чтобы точно добиться своего
            {
                X = rnd.Next(-5, 6); b = X;
                if (a == b)//если 2 числа оказались одинаковыми
                {
                    if (a > 0)
                    {
                        a = Math.Sqrt(a);//вычисляем корень
                    }
                    else if (a < 0)
                    {
                        a = Math.Pow(a, 2);//вычисляем квадрат
                    }
                    break;//выходим из цикла
                }
                a = b;
            }
            ch = Convert.ToString(b); zn = Convert.ToString(a);
        }
    }
}
