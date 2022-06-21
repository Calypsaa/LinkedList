using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class List
    {
        Node head;

        public List()
        {
            head = null;
        }

        public void LastInsert(int data)
        {
            Node value = new Node(data);

            if (head == null)
            {
                head = value;
            }

            else
            {
                Node temp = head;

                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = value;
            }

        }

        public void HeadInsert(int data)
        {
            Node value = new Node(data);

            if (head == null)
            {
                head = value;
            }

            else
            {
                value.next = head;
                head = value;
            }

        }
        public void print()
        {
            Node temp = head;

            if (head == null)
            {
                Console.WriteLine("List is empty");
            }

            while (temp.next != null)
            {
                Console.Write(temp.getData() + " -> ");
                temp = temp.next;
            }

            Console.WriteLine(temp.getData());
        }
        public void HeadDelete()
        {
            if (head == null)
            {
                Console.WriteLine("List is Empty");
            }

            else
            {
                head = head.next;
            }

        }
        public void LastDelete()
        {
            Node temp = head;
            Node temp2 = temp;

            if (head == null)
            {
                Console.WriteLine("List is Empty");
            }

            else if (head.next == null)
            {
                head = null;
            }

            else
            {
                while (temp.next != null)
                {
                    temp2 = temp;
                    temp = temp.next;
                }
                temp2.next = null;
            }
        }
        public void Insert(int index, int data)
        {
            Node value = new Node(data);
            bool Result = false;
            if (head == null && index == 0)
            {
                Result = true;
                head = value;
            }
            else if (index == 0)
            {
                HeadInsert(data);
                Result = true;
            }
            else
            {

                int i = 0;
                Node temp = head;
                Node temp2 = temp;
                while (temp.next != null)
                {
                    if (i == index)
                    {
                        Result = true;
                        temp2.next = value;
                        value.next = temp;
                        i++;
                        break;
                    }
                    temp2 = temp;
                    temp = temp.next;
                    i++;
                }
                if (i == index)
                {
                    Result = true;
                    temp2.next = value;
                    value.next = temp;
                }
            }
            if (Result == false)
            {
                Console.WriteLine("Entered the wrong index");
            }
        }
        public void Delete(int index)
        {
            bool result = false;
            if (head == null)
            {
                result = true;
                Console.WriteLine("List is Empty");
            }
            else if (head.next == null && index == 0)
            {
                result = true;
                head = null;
            }
            else if (head.next != null && index == 0)
            {
                result = true;
                HeadDelete();
            }
            else
            {
                int i = 0; ;
                Node temp = head;
                Node temp2 = temp;
                while (temp.next != null)
                {
                    if (i == index)
                    {
                        result = true;
                        temp2.next = temp.next;
                        i++;
                        break;
                    }
                    temp2 = temp;
                    temp = temp.next;
                    i++;
                }
                if (i == index)
                {
                    result = true;
                    temp2.next = null;
                    i++;
                }
            }
            if (result == false)
            {
                Console.WriteLine("Entered the wrong index");
            }
        }


    }
}
