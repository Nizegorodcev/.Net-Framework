using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_5_Net_Framework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choose;
            while(true) 
            {
                Console.WriteLine("Выберите задание:\n1)Задание 1\n2)Задание 2\n3)Задание 3\n0)Выход");
                choose=Convert.ToInt32(Console.ReadLine());
                switch(choose) 
                {
                    case 1:
                        string s;
                        s = "Удалить все пробелы в этом предложении";
                        Console.WriteLine(s);
                        s = s.Replace(" ", "");
                        Console.WriteLine(s);
                        break;
                   case 2:
                        string str;
                        string str2;
                        char e = ' ';
                        int kol_probel=0;
                        int kol = 0;
                        int index=0;
                        char symbol;
                        string[] str1;
                        string[] newstr;
                        Console.WriteLine("Введите строку");
                        str=Convert.ToString(Console.ReadLine());
                        kol_probel = str.Count(f => (f == e));
                        index = str.LastIndexOf(' ');
                        str1 = str.Split(' ');
                        string stroka;
                        //Console.WriteLine(kol_probel);
                        str2 = str1[str1.Length - 1];
                        for (int i=0; i<str1.Length-1; i++)
                        {
                            if (str1[i] != str2)
                            {
                                str1[i]=str1[i].Remove(0,1);
                            }
                            else
                            {
                               str1[i] =  str1[i].Replace(str1[i], "");
                            }
                        }
                        for(int i=0;i<str1.Length-1;i++) 
                        {
                            Console.WriteLine(str1[i]);
                        }
                        
                       
                        
                        break;
                    case 3:
                        string Str;
                        Console.WriteLine("Введите строку");
                        Str = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Исходная строка");
                        Console.WriteLine(Str);
                        Console.WriteLine("Измененная строка");
                        string sr =Str.ToUpper();
                        Console.WriteLine(sr);
                        break;
                }
            }
            
        }
    }
}
