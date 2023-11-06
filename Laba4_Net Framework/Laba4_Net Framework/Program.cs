using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Laba4_Net_Framework
{
    

    internal class Program
    {
        public static int minarr(int[] arr, int len)
        {
            int min = arr[0];
            for(int i=1;i<len; i++) 
            {
                if (arr[i]<min) 
                {
                    min = arr[i];
                }
            }
            return min;
        }
        public static void printarr (int[] arr, int len)
        {
           
            for (int i = 0; i < len; i++)
            {
                Console.Write(arr[i]+" ");  
            }
            Console.WriteLine("\n");
    
        }
        public static void printarr(int[] arr, int len,int min)
        {

            for (int i = 0; i < len; i++)
            {
                Console.Write(min*arr[i] + " ");
            }
            Console.WriteLine("\n");

        }
        public static int[] SortArray(int[] array, int length)
        {
            for (int i = 1; i < length; i++)
            {
                var key = array[i];
                var flag = 0;
                for (int j = i - 1; j >= 0 && flag != 1;)
                {
                    if (key < array[j])
                    {
                        array[j + 1] = array[j];
                        j--;
                        array[j + 1] = key;
                    }
                    else flag = 1;
                }
            }
            return array;
        }
        static void Main(string[] args)
        {
           
            int choose;
            while(true) 
            {
                Console.WriteLine("Выберите задание:\n1)Задание 1.1\n2)Задание 1.2\n3)Задание 1.3\n4)Задание 1.4\n0)Выход");
                choose=Convert.ToInt32(Console.ReadLine());
                switch (choose) 
                {
                    case 1:
                        Random rnd = new Random();
                        Console.Write("Введите значение n: ");
                        int n = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите значение m: ");
                        int m = Convert.ToInt32(Console.ReadLine());
                        double[] array = new double[n];
                        for (int i = 0; i < n; i++)
                        {
                            int k = rnd.Next(0, 10);
                            array[i] = Math.Round(((int)Math.Pow(2, k)  / Math.Pow(Math.Sqrt(n)+3, 2)));
                        }
                        Random rnd1 = new Random();
                        double[,] array2 = new double[n, m];
                        for (int i = 0; i < n; i++)
                        {
                            for (int j = 0; j < m; j++)
                            {
                                int z = rnd1.Next(0, 10);
                                array2[i, j] = Math.Round(((int)Math.Pow(2, z) / Math.Pow(Math.Sqrt(n) + 3, 2)));
                            }
                        }
                        Console.WriteLine("Массив array:");
                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine($"array[{i}] = {array[i]}");
                        }
                        Console.WriteLine("Двумерный массив array2:");
                        for (int i = 0; i < n; i++)
                        {
                            for (int j = 0; j < m; j++)
                            {
                                Console.Write($"{array2[i, j]}\t");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 2:
                        Console.Write("Введите длину массива А: ");
                        int lenA = Convert.ToInt32(Console.ReadLine());
                        int minA, minB;
                        Console.Write("Введите длину массива В: ");
                        int lenB = Convert.ToInt32(Console.ReadLine());
                        Random rnd2= new Random();
                        Random rnd3 = new Random();
                        int[] A= new int[lenA];
                        int[] B= new int[lenB];
                        Console.WriteLine("Исходные массивы:");
                        for(int i = 0; i < lenA; i++)
                        {
                            A[i] = rnd2.Next(0,10);
                        }
                        for (int i = 0; i < lenB; i++)
                        {
                            B[i] = rnd3.Next(0,10);
                        }
                        Console.WriteLine("Массив А:");
                        printarr(A, lenA);
                        Console.WriteLine("Массив B:");
                        printarr(B, lenB);
                        minA =minarr(A, lenA);
                        minB=minarr(B, lenB);
                        Console.WriteLine("Измененные массивы:");
                        Console.WriteLine("Массив А:");
                        printarr(A, lenA,minA);
                        Console.WriteLine("Массив B:");
                        printarr(B, lenB,minB);
                        break;
                    case 3:
                        Console.WriteLine("Введите N");
                        int N = Convert.ToInt32(Console.ReadLine());
                        int[,] Arr = new int[N, N];
                        Random rnd4= new Random();
                        for(int i = 0; i < N; i++)
                        {
                            for(int j = 0; j < N; j++)
                            {
                                Arr[i,j]=rnd4.Next(0,10);
                            }
                        }
                        int sum = 0;
                        Console.WriteLine("Введите t");
                        int t = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < N; i++)
                        {
                            for (int j = 0; j < N; j++)
                            {
                                if (Arr[i, j] > t)
                                {
                                    sum += Arr[i, j];
                                }
                            }
                        }
                        Console.WriteLine("Двумерный массив Arr:");
                        for (int i = 0; i < N; i++)
                        {
                            for (int j = 0; j < N; j++)
                            {
                                Console.Write($"{Arr[i, j]}\t");
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine("Сумма элементов, больших t равна: " + sum);
                        break;
                    case 4:
                        Console.WriteLine("Укажите размер массива:");
                        int Value = Convert.ToInt32(Console.ReadLine());
                        int[] mas =new int[Value];
                        Random rnd5 = new Random();
                        for (int i = 0; i < Value; i++)
                        {
                            mas[i] = rnd5.Next(1,10);
                        }
                        Console.WriteLine("Первоначальный массив:");
                        printarr(mas, Value);
                        Console.WriteLine("Отсортированный массив:");
                        mas=SortArray(mas,Value);
                        printarr(mas, Value);
                        break;
                }
                if (choose == 0) break;
            }
           
        }
    }
}
