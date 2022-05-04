using System;
using System.Linq;

namespace Module1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            int size = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[size];
            int[] odd = new int[numbers.Length];
            int[] notOdd = new int[numbers.Length];
            char[] charArrToUpper = new char[] { 'a', 'e', 'i', 'd', 'h', 'j' };
            char[] charArr = new char[] { '0', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            // Заполняю массив случаныйми числами
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 26);
            }

            Console.WriteLine();

            // Заполняю 1 массив только четными
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    notOdd[i] = numbers[i];
                    Console.Write(notOdd[i] + " ");
                }
            }

            Console.WriteLine();

            // Заполняю 2 массив нечетными
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    odd[i] = numbers[i];
                    Console.Write(odd[i] + " ");
                }
            }

            Console.WriteLine();

            // Заменяю на буквы алфавита, где значения четного массива совпадают с порядковым номером букв
            string replace = string.Empty;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (notOdd[i] != 0)
                {
                    replace += charArr[notOdd[i]].ToString();
                }
            }

            // Поднимаю определенные буквы в верхний регистр
            char[] inputNotOdds = replace.ToCharArray();
            int index = 0;
            for (int j = 0; j < inputNotOdds.Length; j++)
            {
                if (charArrToUpper.Contains(inputNotOdds[j]))
                {
                    inputNotOdds[j] = inputNotOdds[j].ToString().ToUpper()[0];
                    index++;
                }
            }

            foreach (char c in inputNotOdds)
            {
                Console.Write(c + " ");
            }

            Console.WriteLine();

            // Заменяю на буквы алфавита, где значения нечетного массива совпадают с порядковым номером букв
            string replaceToo = string.Empty;
            for (int i = 0; i < odd.Length; i++)
            {
                if (odd[i] != 0)
                {
                    replaceToo += charArr[odd[i]].ToString();
                }
            }

            // Поднимаю определенные буквы в верхний регистр
            char[] inputOdds = replaceToo.ToCharArray();
            int index1 = 0;
            for (int j = 0; j < inputOdds.Length; j++)
            {
                if (charArrToUpper.Contains(inputOdds[j]))
                {
                    inputOdds[j] = inputOdds[j].ToString().ToUpper()[0];
                    index1++;
                }
            }

            foreach (char c in inputOdds)
            {
                Console.Write(c + " ");
            }

            Console.WriteLine();

            // Вывожу инфу о том, в каком массиве больше элементов с верхним регистром
            if (index > index1)
            {
                Console.WriteLine("Элементов с верх. регистром больше в первом массиве");
            }
            else if (index1 > index)
            {
                Console.WriteLine("Элементов с верх. регистром больше во втором массиве");
            }
            else if (index == index1)
            {
                Console.WriteLine("Одинаковое количество элементов с верх. регистром");
            }
            else
            {
                Console.WriteLine("Элементов нет нигде");
            }

            Console.ReadKey();
        }
    }
}