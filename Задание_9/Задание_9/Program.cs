using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PI_Zad9
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
            bool res = list.Delete(1);

            list.Show();

            res = list.Delete(5);

            list.Show();

            Console.ReadLine();
        }
    }
}
