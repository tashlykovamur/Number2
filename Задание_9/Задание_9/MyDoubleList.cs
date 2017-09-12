using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PI_Zad9
{
    public class MyDoubleList
    {
        class ListItem
        {
            public int Data { get; set; }
            public ListItem Previous { get; set; }
            public ListItem Next { get; set; }
        }

        private ListItem first;
        private ListItem last;

        public void Add(int item)
        {
            ListItem li = new ListItem();
            li.Data = item;

            if (first == null)
            {
                first = li;
                last = li;
            }
            else
            {
                last.Next = li;
                li.Previous = last;
                last = li;
            }
        }

        public void Show()
        {
            ListItem beg = first;

            while (beg != null)
            {
                Console.Write(beg.Data + " ");

                beg = beg.Next;
            }

            Console.WriteLine();
        }

        public bool Find(int el)
        {
            ListItem beg = first;
            bool find = false;

            while (beg != null)
            {
                if (beg.Data == el)
                {
                    find = true;
                    break;
                }

                beg = beg.Next;
            }

            return find;
        }

        public bool Delete(int el)
        {
            bool result = false;

            if (Find(el))
            {
                ListItem beg = first;
                result = true;

                //если удаляем первый элемент
                if (beg.Data == el)
                {
                    first = beg.Next;
                    first.Previous = null;

                    if (first == null)
                        last = null;
                }
                else
                {
                    while (beg != null)
                    {
                        if (beg.Data == el)
                        {
                            beg.Previous.Next = beg.Next;
                            if (beg.Next != null)
                                beg.Next.Previous = beg.Previous;

                            if (beg == last)
                                last = beg.Previous;

                            break;
                        }

                        beg = beg.Next;
                    }
                }
            }

            return result;
        }
    }
}