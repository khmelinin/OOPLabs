using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7Sharp
{
    class MyCollection
    {
        Node head;
        Node tail;
        int count = 0;

        public MyCollection(char data)
        {
            Push(data);
        }

        public MyCollection(char[]data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                Push(data[i]);
            }
        }

        public MyCollection(string data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                Push(data[i]);
            }
        }

        public override string ToString()
        {
            Node current = head;
            string tmp = "";
            while (current != null)
            {
                tmp += current.Data;
                current = current.Next;
            }

            return tmp;
        }
        
        public int Count { get => count; }
        public bool IsEmpty { get => count == 0; }
        public void Push(char data)
        {
            Node tmp = new Node(data);
            if(head==null)
            {
                head = tmp;
            }
            else
            {
                tail.Next = tmp;
            }
            tail = tmp;
            count++;
        }
        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public bool Contains(char data)
        {
            Node current = head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                    return true;
                current = current.Next;
            }
            return false;
        }
        public int FindCount(char data)
        {
            Node current = head;
            int tmp = 0;
            while (current != null)
            {
                if (current.Data.Equals(data))
                    tmp++;
                current = current.Next;
            }
            return tmp;
        }
        public void DelAfter(char data)
        {
            Node current = head;
            int tmp = 0;
            while (current != null)
            {
                tmp++;
                if (current.Data.Equals(data))
                {
                    current.Next = null;
                    count = tmp;
                }
                current = current.Next;
            }
        }

    }
}
