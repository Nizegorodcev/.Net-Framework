using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_6_Net.Framework
{
    public class cargo_plane
    {
        public string model;
        public float load_capability;
        public float Volume;
        public void Print()
        {
            Console.WriteLine("Модель: "+ model);
            Console.WriteLine("Грузоподъёмность: "+ load_capability);
            Console.WriteLine("Объём: " + Volume);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int choose;
            Console.WriteLine("Выберите действие:\n1)Задание 1\n2)Задание 2\n0)Выход");
            choose=Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                switch (choose)
                {
                    case 1:
                        List<int> arr = new List<int>();
                        int choose1;
                        while(true)  
                        {
                            Console.WriteLine("Выберите функцию:\n1)Добавить число\n2)Удалить число по индексу\n3)Поиск по числу\n4)Очистка списка\n5)Сортировка\n0)Выход");
                            choose1= Convert.ToInt32(Console.ReadLine());
                            switch(choose1) 
                            {
                                case 1:
                                    int chislo;
                                    Console.WriteLine("Введите число");
                                    chislo= Convert.ToInt32(Console.ReadLine());    
                                    arr.Add(chislo);
                                    break;
                                case 2:
                                    int index;
                                    for (int i = 0; i < arr.Count; i++)
                                    {
                                        Console.WriteLine("index = "+ i+" value = " +  arr[i]);
                                    }
                                    Console.WriteLine("Введите индекс члена массива, который вы хотите удалить");
                                    index= Convert.ToInt32(Console.ReadLine());
                                    if (index < 0 || index > arr.Count)
                                    {
                                        Console.WriteLine("Вы указали неверное значение индекса");
                                    }
                                    else arr.RemoveAt(index);
                                    for (int i = 0; i < arr.Count; i++)
                                    {
                                        Console.WriteLine("index = " + i + " value = " + arr[i]);
                                    }
                                    break;
                                case 3:
                                    int value;
                                    for (int i = 0; i < arr.Count; i++)
                                    {
                                        Console.WriteLine("index = " + i + " value = " + arr[i]);
                                    }
                                    Console.WriteLine("Введите число, которые вы хотите найти в списке");
                                    value = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine(arr.Contains(value));                                
                                    break;
                                case 4:
                                    for (int i = 0; i < arr.Count; i++)
                                    {
                                        Console.WriteLine("index = " + i + " value = " + arr[i]);
                                    }
                                    arr.Clear();
                                    Console.WriteLine("Списком очищен");
                                    break;
                                case 5:
                                    Console.WriteLine("Первоначальный список");
                                    for (int i = 0; i < arr.Count; i++)
                                    {
                                        Console.WriteLine("index = " + i + " value = " + arr[i]);
                                    }
                                    arr.Sort();
                                    Console.WriteLine("Отсортированный список");
                                    for (int i = 0; i < arr.Count; i++)
                                    {
                                        Console.WriteLine("index = " + i + " value = " + arr[i]);
                                    }
                                    break;
                            }
                            if(choose1==0) {break;}
                        }
                        break;
                    case 2:
                        cargo_plane a=new cargo_plane();
                        a.model = "ИЛ-76";
                        a.Volume = 140;
                        a.load_capability = 20;
                        cargo_plane b = new cargo_plane();
                        List<cargo_plane> planes = new List<cargo_plane>();
                        planes.Add(a);
                        int choose2;
                        while (true) 
                        {
                            Console.WriteLine("Выберите действие:\n1)Запись полей объекта класса \n2)Добавление объекта в список\n3)Вывод элементов списка\n0)Выход");
                            choose2=Convert.ToInt32(Console.ReadLine());
                            switch (choose2)
                            {
                                case 1:
                                    Console.WriteLine("Укажите модель самолета: ");
                                    b.model=Convert.ToString(Console.ReadLine());
                                    Console.WriteLine("Укажите максимальную грузоподъёмность самолета: ");
                                    b.load_capability = (float)Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Укажите максимальный объём перевозимого товара в самолете: ");
                                    b.Volume = (float)Convert.ToDouble(Console.ReadLine());
                                    break;
                                case 2:
                                    planes.Add(b);
                                    break;
                                case 3:
                                    for(int i=0;i<planes.Count;i++)
                                    {
                                        planes[i].Print();
                                    }
                                    break;
                            }

                            if (choose2 == 0) { break;}
                        }
                        break;
                }
                if(choose==0) 
                {
                    break;
                }
            }
           
        }
    }
}
