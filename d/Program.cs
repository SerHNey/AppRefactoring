using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            string enter = Console.ReadLine();
            Console.WriteLine("Выберите цикл =  1 - for\n 2-foreach");
            if (enter == "1")
            {
                for (int i = 0; i < array.Length; i++)
                {
                     if (array[i] == 1)
                    Console.WriteLine($"Элемент массива = {array[i]}");
                }
            }
            if (enter == "2")
            {
                foreach (int grade in array)
                {
                    if (grade == 5)
                    Console.WriteLine($"Элемент массива = {grade}");
                }
            }

            switch (enter)
            {
                case "1":
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[i] == 1)
                            Console.WriteLine($"Элемент массива = {array[i]}");
                    }
                    break;
                case "2":
                    foreach (int grade in array)
                    {
                        if (grade == 5)
                            Console.WriteLine($"Элемент массива = {grade}");
                    }
                    break;
            }
            getelem(array);

            Console.ReadLine();
        }
        static int getelem(int[] ints)
        {
            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] == 6)
                    Console.WriteLine($"Элемент массива = {ints[i]}");

                
            }
            return 1;
            if (ints.Length == 2) ;
        }
        static int getelem2(int[] ints)
        {
            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] == 6)
                    Console.WriteLine($"Элемент массива = {ints[i]}");


            }
            return 1;
        }
    }
}
