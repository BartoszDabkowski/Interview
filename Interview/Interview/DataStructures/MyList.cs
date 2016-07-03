using System;
using System.Collections.Generic;

namespace Interview.DataStructures
{
    public class MyList
    {
        private class Node
        {
            public int data { get; set; }
            public Node next { get; set; }

            public Node(int data)
            {
                this.data = data;
            }
        }

        private Node head { get; set; }

        public void InsertToEnd(int data)
        {
            var ins = new Node(data);
            if (head == null)
            {
                head = ins;
            }
            else
            {
                var cur = head;
                while (cur.next != null)
                {
                    cur = cur.next;
                }
                cur.next = ins;
            }
        }

        public void InsertSorted(int data)
        {
            Node ins = new Node(data);
            if (head == null)
            {
                head = ins;
            }
            else
            {
                Node cur = head;
                Node prev = null;
                while (cur != null)
                {
                    if (ins.data <= cur.data)
                    {
                        break;
                    }
                    else
                    {
                        prev = cur;
                        cur = cur.next;
                    }
                }

                if (head == cur)
                {
                    ins.next = head;
                    head = ins;
                }
                else
                {
                    prev.next = ins;
                    ins.next = cur;
                }
            }
        }

        public void Remove(int data)
        {
            if (head != null)
            {
                Node cur = head;
                Node prev = null;

                while (cur != null)
                {
                    if (cur.data == data)
                    {
                        if (head == cur)
                        {
                            head.next = head.next;
                            cur = null;
                        }
                        else
                        {
                            prev.next = cur.next;
                            cur = null;
                        }
                    }
                    else
                    {
                        prev = cur;
                        cur = cur.next;
                    }
                }
            }
        }

        public void Display()
        {
            Node cur = head;

            while (cur != null)
            {
                Console.Write(cur.data + " ");
                cur = cur.next;
            }
        }

        public void RemoveDuplicates()
        {
            var hashSet = new HashSet<int>();

            if (head != null)
            {
                var cur = head;
                Node prev = null;

                while (cur != null)
                {
                    if (hashSet.Contains(cur.data))
                    {
                        cur = cur.next;
                        prev.next = cur;
                    }
                    else
                    {
                        hashSet.Add(cur.data);
                        prev = cur;
                        cur = cur.next;
                    }
                }

            }
        }

        public void RemoveDuplicates2()
        {
            if (head == null)
                return;

            var cur = head;

            while (cur != null)
            {
                var curRunner = cur.next;
                Node prevRunner = cur;
                while (curRunner != null)
                {
                    if (curRunner.data == cur.data)
                    {
                        prevRunner.next = curRunner.next;
                        curRunner = curRunner.next;
                    }
                    else
                    {
                        prevRunner = curRunner;
                        curRunner = curRunner.next;
                    }
                }

                cur = cur.next;
            }

        }

        public void RemoveKthFromLast(int k)
        {
            if (head == null)
                return;

            var cur1 = head;
            var cur2 = head;

            for (var i = 0; i < k; i++)
            {
                if (cur1 == null)
                    return;
                cur1 = cur1.next;
            }
            if (cur1 == null)
            {
                head = head.next;
                return;
            }

            while (cur1.next != null)
            {
                cur1 = cur1.next;
                cur2 = cur2.next;
            }
            cur2.next = cur2.next.next;

        }

        public override string ToString()
        {
            var list = "";

            Node cur = head;

            while (cur != null)
            {
                list += cur.data + " ";
                cur = cur.next;
            }

            return list;
        }
    }
}
