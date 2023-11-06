using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//double RoundF(double d, int digits)
//{
//    if (d == 0)
//    { 
//        return 0; 
//    }
//    double scale = Math.Pow(10, Math.Floor(Math.Log10(Math.Abs(d))) + 1);
//    return scale * Math.Round(d / scale, digits);
//}
namespace Laba3_Net_Framework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choose;
            float res, d;
            while (true) 
            {
                Console.WriteLine("Выберите действие:\n0)Выход\n1)Задание 2\n2)Задание 3\n3)Задание 4");
                choose=Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        int start, finish;
                        Console.WriteLine("Введите начальное значение интервала");
                        start = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите конечное значение интервала");
                        finish = Convert.ToInt32(Console.ReadLine());
                        int kol;
                        if (start == 0)
                        {
                           kol = (finish % 2 == 0) ?  (finish / 2) + 1 : ((finish - 1) / 2) + 1;
                        }
                        else
                        {
                            kol = (finish % 2 == 0) ? (finish / 2) : ((finish - 1) / 2);
                        }
                        Console.WriteLine("Количество четных чисел равно: " + kol);
                        break;
                    case 2:
                        int A, B, N;
                        int kolN = 0;
                      
                        Console.WriteLine("Введите число А:");
                        A = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите число В:");
                        B = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите число N, чтобы исключить определенное количество чисел:");
                        N = Convert.ToInt32(Console.ReadLine());
                        if(A>B) 
                        {
                            for(int i = B + 1; i < A; i++)
                            {
                                if(kolN!=N) 
                                {
                                    kolN += 1;
                                }
                                else
                                {
                                    Console.WriteLine(i+"\n");
                                }
                            }
                        }
                        if(A<B) 
                        {
                            Console.WriteLine("Результат:");
                            for (int i = A + 1; i < B; i++)
                            {
                                if (kolN != N)
                                {
                                    kolN += 1;
                                }
                                else
                                {
                                    Console.WriteLine(i);
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Целых значений на этом отрезке не существует");
                        }
                        break;
                    case 3:
                        double chislo=1.1;
                        double sum=0;
                        int len = 0;
                        double [] arr = new double[1000];
                        while (chislo>0) 
                        {
                            Console.WriteLine("Введите число:");
                            chislo = Convert.ToDouble(Console.ReadLine());
                            arr[len] = chislo;
                            len += 1;
                            
                        }
                       
                        
                        for(int i=0;i<len-1;i++)
                        {
                            sum += arr[i];
                        }
                        len = len - 1;
                        Console.WriteLine(sum);
                        Console.WriteLine(len);
                        double result = sum / len;
                        Console.WriteLine(Math.Round(result,2));
                      
                        break;

                }

                if (choose == 0) break;
            }
        }
    }
}
