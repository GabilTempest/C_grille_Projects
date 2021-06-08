using System;

namespace ЛБ_3
{
    class Program
    {
        static void Main(string[] args)
        {

            int firstId = 0, lastId = 0;

            bool firelem = false;

            Console.WriteLine("n:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("b:");
            int b = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            int[] array2 = new int[n];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-10, 10);

                Console.Write(array[i] + " ");
            }

            int sum = 0;
            int max = array[0];
            for (int i = 1; i < n; ++i)
                if (array[i] > max)
                    max = array[i];
            Console.WriteLine(" ");
            Console.WriteLine("MAX:" + " " + max);

            for (int i = 0; i < n; i++)
            {
                if (array[i] > 0)
                {
                    if (!firelem)
                    {
                        firstId = lastId = i;
                        firelem = true;
                    }
                    else
                    {
                        lastId = i;
                    }
                }
            }


            for (int i = firstId; i < lastId + 1; i++)
            {
                sum += array[i];
            }

            Console.WriteLine();


            Console.WriteLine("сумма = " + sum);

            for (int i = 0, j = 0; i < array.Length; i++)
            {
                //  if (Math.Ab(array[i]) < a || Math.Abs(array[i]) > b)
                if (array[i] < a || array[i] > b)
                {
                    array2[j] = array[i];
                    j++;
                }
            }

            foreach (var i in array2)
                Console.Write(i + " ");



        }


    }
}

