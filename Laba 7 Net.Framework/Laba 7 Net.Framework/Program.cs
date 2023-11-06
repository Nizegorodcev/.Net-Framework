using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Laba_7_Net.Framework
{
    
    internal class Program
    {
        public static void filling_the_array(ref int[,] arr, int x, int y)
        {
            Random random= new Random();

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    arr[i, j] = random.Next(-10, 10);
                }
              
            }
        }
        public static int minimum_in_line(int[,] arr, int x, int y,out int res)
        {
            int min = arr[0,0];
            res = 0;
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (Math.Abs(min) > Math.Abs(arr[i, j]))
                    {
                        min = arr[i, j];
                    }
                } 
            }
            Console.WriteLine("Минимальный по модулю элемент массива: " + min);
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (Math.Abs(min) == Math.Abs(arr[i, j]))
                    {
                        res  += 1;
                        break;
                    }
                }

            }
            return res;
        }
        public static void printarr(int[,] arr,int x,int y)
        {
            Console.WriteLine("Двумерный массив:");
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write($"{arr[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
        public static void printarr(int[] arr, int size)
        {
            Console.WriteLine("Одномерный массив:");
            Console.Write("[");
            for (int i = 0; i < size; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine("]");
        }
        public static double A(double x, double y)
        {
            return x * x / (8 + ((x * x) / 3) + (y * y) / 6);
        }
        public static double B(double x, double z)
        {
            return x * (Math.Pow(Math.Cos(x + z), 3) + 1);
        }
        public static int search_for_positive_elements(int[] arr, int size, out int result)
        {
            result= 0;
            for (int i = 0; i < size; i++)
            {
                if (arr[i] > 0) { result += 1; }
            }
            return result;
        }
        public static double U(in double a,in double b,out double u)
        {
            u = Math.Max(a, b - a);
            return u;
        }
        public static double V(in double a, in double b, out double v)
        {
            v = Math.Max((a*10)+b, a+b);
            return v;
        }
        public static double K( double u, double v, out double k)
        {
            k=Math.Min(u+(2*v), Math.PI);
            return k;
        }
        public static void replace(ref object a, ref object b)
        {
            object c = a;
            a = b; b = c;
        }
        public static double Rast(double Ax , double Bx,double Ay,double By,out double res)
        {
            res= Math.Sqrt(Math.Pow(Ax - Bx, 2) + Math.Pow(Ay - By, 2));
            return res;
        }
        public static double Perimetr(double AB, double BC, double AC,bool flag = false,double Ax=0,double Ay=0,double Bx=2,double By=0,double Cx=1,double Cy=2)
        {
            double res,res1,res2;
            if (flag)
            {
                return AB + BC + AC;
            }
            
            else
            {
                return Rast(Ax, Bx, Ay, By, out res) + Rast(Ax, Cx, Ay, Cy, out res1) + Rast(Bx, Cx, By, Cy, out res2);
            }
            
        }
        static void Main(string[] args)
        {
            int choose;
            while(true) 
            {
                Console.WriteLine("Выберите действие:\n1)Задание 1.1\n2)Задание 1.2\n3)Задание 1.3\n4)Задание 2\n5)Задание 3\n6)Задание 4");
                choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        Console.WriteLine("Введите число строк");
                        int x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите число столбцов");
                        int y = Convert.ToInt32(Console.ReadLine());
                        int[,] data = new int[x, y];
                        filling_the_array(ref data, x, y);
                        printarr(data, x, y);
                        int res = 0;
                        minimum_in_line(data, x, y, out res);
                        Console.WriteLine("Число строк с минимальным по модулю элементом: " + res);
                        break;
                    case 2:
                        double x1, y1, z;
                        Console.WriteLine("Введите x:");
                        x1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите y:");
                        y1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите z:");
                        z = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("A= " + A(x1, y1));
                        Console.WriteLine("B= " + B(x1, z));
                        break;
                    case 3:
                        int size;
                        int result;
                        Random rnd= new Random();
                        Console.WriteLine("Укажите размер одномерного массива:");
                        size=Convert.ToInt32(Console.ReadLine());
                        int[] arr = new int[size];
                        for (int i = 0; i < size; i++)
                        {
                            arr[i]=rnd.Next(-10,10);
                        }
                        search_for_positive_elements(arr,size,out result);
                        printarr(arr, size);
                        Console.WriteLine("Число положительных элементов в масссиве: " + result);
                        break;
                    case 4:
                        double a,b,u,v,k;
                        
                        Console.WriteLine("Введите a:");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите b:");
                        b = Convert.ToDouble(Console.ReadLine());
                        U(in a, in b, out u);
                        V(in a, in b, out v);
                        K(u,v,out k);
                        Console.WriteLine("U= " + u);
                        Console.WriteLine("V= " + v);
                        Console.WriteLine("K= " + k);
                        break;
                    case 5:
                        object one, two;
                        Console.WriteLine("Введите первый объект:");
                        one=Console.ReadLine();
                        Console.WriteLine("Введите второй объект:");
                        two = Console.ReadLine();
                        replace(ref one,ref two);
                        Console.WriteLine("Первый объект: " + one);
                        Console.WriteLine("Первый объект: " + two);
                        break;
                    case 6:
                        double Ax, Ay, Bx, By, Cx, Cy,res1,res2,res3;
                        Console.WriteLine("Введите координату точки А по x:");
                        Ax = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите координату точки А по y:");
                        Ay = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите координату точки B по x:");
                        Bx = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите координату точки B по Y:");
                        By = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите координату точки C по x:");
                        Cx = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите координату точки C по Y:");
                        Cy = Convert.ToDouble(Console.ReadLine());
                        if ((Ax == Bx && Ax == Cx)|| (Ay == By && Ay == Cy))
                        {
                            Console.WriteLine("Треугольника не существует");
                        }
                        else
                        {
                            Rast(Ax, Bx, Ay, By,out res1);
                            Rast(Ax, Cx, Ay, Cy, out res2);
                            Rast(Bx, Cx, By, Cy, out res3);
                            Console.WriteLine("Первая сторона: " + res1);
                            Console.WriteLine("Вторая сторона: " + res2);
                            Console.WriteLine("Третья сторона: " + res3);
                            double result2 = Perimetr(res1, res2, res3, false);
                            Console.WriteLine(result2);
                        }
                      
                        break;
                }
                if (choose == 0) { break; }
            }
         
           
        }
    }
}
