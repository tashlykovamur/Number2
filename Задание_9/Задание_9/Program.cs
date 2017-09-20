using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Задание9
{
    class Program
    {
        static MyDoubleList CreateList()
        {
            MyDoubleList list = new MyDoubleList();

            Console.WriteLine("Введите n");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                list.Add(i);
            }

            return list;
        }
        static void Main(string[] args)
        {
            MyDoubleList list = CreateList();
            list.Show();

            bool find = list.Find(4);
            if (find)
                Console.WriteLine("В списке найден элемент со значением 4");
            else Console.WriteLine("Элемент со значением 4 не найден");

           bool res = list.Delete(2);
            if (res)
                Console.WriteLine("В списке найден элемент со значением 2 и удален");
            else
            Console.WriteLine("Элемента со значением 2 нет в списке, значит удалить его нельзя");
            list.Show();
           

            Console.ReadLine();
        }
    }
}
