using System;
using System.Linq;

namespace Pract
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = ArrayWithRandomNumbers();
            int[] notOdd = NotOddArray();
            int[] odd = OddArray();
            char[] charArrToUpper = new char[] { 'a', 'e', 'i', 'd', 'h', 'j' };
            char[] abc = Alphabet();

            // Заполняю 1 массив только четными
            int[] NotOddArray()
            {
                int[] notOddArry = new int[numbers.Length];
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        notOddArry[i] = numbers[i];
                        Console.Write(notOddArry[i] + " ");
                    }
                }

                return notOddArry;
            }

            // Заполняю 2 массив только нечетными
            int[] OddArray()
            {
                Console.WriteLine();
                int[] oddArray = new int[numbers.Length];
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 != 0)
                    {
                        oddArray[i] = numbers[i];
                        Console.Write(oddArray[i] + " ");
                    }
                }

                return oddArray;
            }

            Console.WriteLine();

            // Заменяю на буквы алфавита, где значения четного массива совпадают с порядковым номером букв
            string replace = string.Empty;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (notOdd[i] != 0)
                {
                    replace += abc[notOdd[i]].ToString();
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
                    replaceToo += abc[odd[i]].ToString();
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

        public static char[] Alphabet()
        {
            char[] alphabet = new char[27];
            int count = 1;
            for (char i = 'a'; i <= 'z'; i++)
            {
                alphabet[count++] = i;
            }

            return alphabet;
        }

        public static int[] ArrayWithRandomNumbers()
        {
            Random random = new Random();
            int size = Convert.ToInt32(Console.ReadLine());
            int[] numbers1 = new int[size];

            // Заполняю массив случаныйми числами
            for (int i = 0; i < numbers1.Length; i++)
            {
                numbers1[i] = random.Next(1, 26);
            }

            Console.WriteLine();
            return numbers1;
        }
    }
}