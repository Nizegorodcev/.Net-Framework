using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Task1 
{ 
    public static double A(double x,double y)
    {
        return x*x/(8+((x*x)/3)+(y*y)/6 );
    }
    public static double B(double x, double z)
    {
        return x * (Math.Pow(Math.Cos(x + z), 3) + 1);
    }
    public static double finding_a_third_party_of_triangle(int a,int b, int alpha)//Нахождение третьей стороны
    {
        double radian = (alpha * Math.PI) / 180;
        return Math.Sqrt((a * a) + (b * b) - (2 * a * b * Math.Cos(radian)));
        //Math.Sqrt((a*a)+(b*b)-(2*a*b*Math.Cos(alpha)));
        //0.5*a*b*Math.Sin(radian)
    }
    public static void belonging_to_a_circle(double x, double y)//  Принадлежность окружности
    {
        if (x * x + y * y <= 1) Console.WriteLine("Данная точка принадлежит окружности");
        else Console.WriteLine("Данная точка не принадлежит окружности");
    }
    public static double longCircle(double sircle_radius)//Длина окружности
    {
        return 2 * Math.PI * sircle_radius;
    }
    public  static double sqrCircle(double sircle_radius)
    {
        return Math.PI * sircle_radius* sircle_radius;
    }
    public static double sqrCylinder(double cylinder_radius,double height_cylinder)
    {
        return Math.PI * cylinder_radius * cylinder_radius * height_cylinder;
    }
   
}
public   struct Residential_building//Жилой дом
{
 
    int floor_count;//Число этажей
    int entrance;//Число подъездов
    int number_of_apartments;//Число квартир на этаже
    public void Print()
    {
        Console.WriteLine($"Число этажей в доме: {floor_count}\nЧисло подъездов в доме: {entrance}\nЧисло квартир на каждом этаже: {number_of_apartments}");
    }
    public void set_floor_count(int floor_count)
    {
        this.floor_count = floor_count;
    }
    public void set_entrance(int entrance)
    {
        this.entrance = entrance;
    }
    public void set_number_of_apartments(int number_of_apartments)
    {
        this.number_of_apartments = number_of_apartments;
    }
}
namespace Net.Framework_Laba_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Выберите действие:\n1)Задание 1.1\n2)Задание 1.2\n3)Задание 1.3\n4)Задание 1.4\n5)Задание 2");
                int choose = Convert.ToInt16(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        double x, y,z;
                        Console.WriteLine("Введите x:");
                        x = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите y:");
                        y = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите z:");
                        z = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("A= " + Task1.A(x,y));
                        Console.WriteLine("B= " + Task1.B(x, z));
                        break;
                    case 2:
                        int a, b, alpha;
                        Console.WriteLine("Введите сторону А:");
                        a = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Введите сторону B:");
                        b = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Введите  значение угла между  данными сторонами:");
                        alpha = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Третья сторона равна: "+Task1.finding_a_third_party_of_triangle(a,b,alpha));
                        break;
                    case 3:
                        double x1, y1;
                        Console.WriteLine("Введите x:");
                        x1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите y:");
                        y1 = Convert.ToDouble(Console.ReadLine());
                        Task1.belonging_to_a_circle(x1,y1);
                        break;
                    case 4:
                        char symbol;
                        double sircle_radius, cylinder_radius, height_cylinder;
                        Console.WriteLine("Введите символ:\n1)L - Для нахождения длины окружности\n2)M - Для нахождения площади круга\n3)V - Для нахождения объёма цилиндра");
                        symbol=Convert.ToChar(Console.ReadLine());
                        if (symbol == 'L')
                        {
                            Console.WriteLine("Введите радиус окружности: ");
                            sircle_radius = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine($"Длина окружности радиусом  {sircle_radius}  равна   {Task1.longCircle(sircle_radius)}") ;
                        }
                        if (symbol == 'M')
                        {
                            Console.WriteLine("Введите радиус окружности: ");
                            sircle_radius = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine($"Площадь окружности радиусом {sircle_radius}  равна {Task1.sqrCircle(sircle_radius)}");
                        }
                        if (symbol == 'V')
                        {
                            Console.WriteLine("Введите радиус цилиндра: ");
                            cylinder_radius = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Введите высоту цилиндра: ");
                            height_cylinder = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine($"Объём цилиндра радиусом {cylinder_radius} и высотой {height_cylinder}  равен {Task1.sqrCircle(cylinder_radius)}");
                        }
                        break;
                        case 5:
                        int floor_count;//Число этажей
                        int entrance;//Число подъездов
                        int number_of_apartments;//Число квартир на этаже
                        Residential_building A = new Residential_building() ;
                        Console.WriteLine("Укажите число этажей в доме: ");
                        floor_count= Convert.ToInt16(Console.ReadLine());
                        A.set_floor_count(floor_count);
                        Console.WriteLine("Укажите число подъездов в доме: ");
                        entrance = Convert.ToInt16(Console.ReadLine());
                        A.set_entrance(entrance);
                        Console.WriteLine("Укажите число квартир на каждом этаже: ");
                        number_of_apartments= Convert.ToInt16(Console.ReadLine());
                        A.set_number_of_apartments(number_of_apartments);
                        A.Print();
                        break;
                    
                }
            }
               
        }
    }
}
