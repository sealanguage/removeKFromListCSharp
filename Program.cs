using System;

namespace emoveKFromList
{
    class Program
    {
        static void Main(string[] args)
        {
            // Definition for singly-linked list:
            // class ListNode<T> {
            //   public T value { get; set; }
            //   public ListNode<T> next { get; set; }
            // }
            //
            ListNode<int> removeKFromList(ListNode<int> l, int k)
            {
                if (l == null)
                {
                    return l;
                }
                Console.WriteLine(l.value);

                while (l.value == k)
                {
                    if (l.next == null)
                    {
                        return l.next;
                    }
                    l = l.next;
                }

                ListNode<int> trav = l;
                while (trav.next != null)
                {
                    if (trav.next.value == k)
                    {
                        trav.next = trav.next.next;
                        continue;
                    }
                    trav = trav.next;
                }
                return l;
            }

        }
    }
}
