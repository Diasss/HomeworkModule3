using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkModule3
{
    class Program
    {
        static void Main(string[] args)
        {
            DvumerniyMassiv();
        }

        static void Array()
        {
            int[] arr = new int[10];
            Random rand = new Random();
            int max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(1, 10);
                if (arr[i] > max) { max = arr[i]; }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("{0}", arr[i]);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == max) { Console.WriteLine("{0} - Индекс макс значения массива", i); }
            }
            max = 0;
            Console.Write("\n-------------------------------------------------------\n");
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0 || arr[i] > max)
                {
                    max = arr[i];
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == max || i % 2 == 0)
                {
                    Console.WriteLine("{0} - Индекс максимального четного значения");
                }
            }
            Console.Write("\n------------------------------------------------------------\nВведите индекс массива, который вы бы хотели удалить: ");
            int searchArrayToDelete = Int32.Parse(Console.ReadLine());
            int[] arr1 = new int[arr.Length - 1];
            for (int i = 0; i < arr.Length-1; i++)
            {
                if (i == searchArrayToDelete-1)
                {
                    arr1[i] = arr[i + 1];
                    i++;
                }
                else
                {
                    arr1[i] = arr[i];
                }
            }
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write("{0} ", arr1[i]);
            }
        }

        static void taskLuckyTicket()
        {
            int ticket = Int32.Parse(Console.ReadLine());
            int sum1 = 0, sum2 = 0;
            for (int i = 0; i < 3; i++)
            {
                sum1 += ticket % 10;
                ticket = ticket / 10;
            }
            for (int i = 0; i < 3; i++)
            {
                sum2 += ticket % 10;
                ticket = ticket / 10;
            }
            if (sum1 == sum2)
            {
                Console.WriteLine("Билет счастливый!");
            }
            else
            {
                Console.WriteLine("Билет несчастливый!");
            }
        }
        static void taskTochka()
        {
            char simvol;
            int probel=0;
            do
            {
                simvol = (char)Console.ReadKey().KeyChar;
                if (simvol == ' ')
                {
                    probel++;
                }
            } while (simvol!='.');
            Console.WriteLine(probel);
        }
        /// <summary>
        /// Я не смог сделать это задание чет запутался
        /// </summary>
        //static void ASCII()
        //{
        //    char str;
        //    int z;
        //    int count = 0;
        //    do
        //    {
        //        z = Console.Read();
        //        str = (char)z;

        //        count++;
        //    } while (str != '.');
        //    for (int i = 0; i < count; i++)
        //    {
        //        if (str[i] > (char)64 || (char)z < 91)
        //        {
        //            str = (char)(z + 32);
        //        }
        //        if ((char)z > 96 || (char)z < 123)
        //        {
        //            str = (char)(z - 32);
        //        }
        //    }
        //}
        static void taskSpravaNalevo()
        {
            string num = Console.ReadLine();
            for (int i = num.Length-1; i >=0 ; i--)
            {
                Console.Write(num[i]);
            }
        }
        static void DvumerniyMassiv()
        {
            int multiplyA = 1;
            double multiplyB = 1;
            double multiplyAB = 1;
            int[] a = new int[5];
            double[,] b = new double[3, 4];
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("{0})Элемент: ", i+1);
                a[i] = Int32.Parse(Console.ReadLine());
            }
            Console.Clear();
            Random rand = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    b[i, j] = rand.NextDouble();
                }
            }
            int sumA = 0;
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("{0}, ", a[i]);
                sumA += a[i];
                multiplyA *= a[i];
            }
            Console.WriteLine("\n----------------------------------\n");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("{0}, ", b[i,j]);
                }
                Console.WriteLine("");
            }
            double maxB2 = 0;
            double minB2 = double.MaxValue;
            double sumB = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (maxB2 < b[i, j])
                    {
                        maxB2 = b[i, j];
                    }
                    if (minB2 > b[i, j])
                    {
                        minB2 = b[i, j];
                    }
                    sumB += b[i, j];
                    multiplyB *= b[i, j];
                }
            }
            Console.WriteLine("Максимальный элемент в массиве A - {0}", a.Max());
            Console.WriteLine("Минмимальный элемент в массиве A - {0}", a.Min());
            Console.WriteLine("Максимальный элемент в массиве B - {0}", maxB2);
            Console.WriteLine("Минмимальный элемент в массиве B - {0}", minB2);            
            Console.WriteLine("\n--------------------------------------\n");
            if (a.Max() > maxB2)
            {
                Console.WriteLine("Общий Максимальный элемент - {0}", a.Max());
            }
            else
                Console.WriteLine("Общий Максимальный элемент - {0}", maxB2);
            Console.WriteLine("\n--------------------------------------------\n");
            double sumAB = sumA + sumB;
            Console.WriteLine("Сумма всех элементов = {0}", sumAB);
            Console.WriteLine("\n--------------------------------------------\n");
            multiplyAB = multiplyB * multiplyA;
            Console.WriteLine("Общее проезведение = {0}", multiplyAB);
            Console.WriteLine("\n--------------------------------------------\n");
        }
    }
}
