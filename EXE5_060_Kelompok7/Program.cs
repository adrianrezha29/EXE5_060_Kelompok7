using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE5_060_Kelompok7
{
    class Node
    {
        public string data;
        public Node next;
    }
    class QueueLinkedList
    {
        Node Adrian, Rezha;

        public QueueLinkedList()
        {
            Adrian = null;
            Rezha = null;
        }
        public void Enter()
        {
            string value;
            Console.WriteLine("\nEnter the element");
            value = Console.ReadLine();
            Node newnode = new Node();
            newnode.data = value;
            if (Adrian == null)
            {
                Adrian = newnode;
                Rezha = newnode;
                return;
            }
            else
            {
                Rezha.next = newnode;
                Rezha = newnode;
            }
        }
        public void Delete()
        {
            if(Adrian == null)
            {
                Console.WriteLine("\nQueue Is Empty!!");
                return;
            }
            Adrian = Adrian.next;
        }
        public void Display()
        {
            if (Adrian == null)
            {
                Console.WriteLine("\nQueue is Empty or Filled !!");
                return;
            }
            Node Display;
            for (Display = Adrian; Display != null; Display = Display.next)
                Console.WriteLine(Display.data);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            QueueLinkedList q = new QueueLinkedList();
            char ch;
            while (true)
            {
                try
                {
                    Console.WriteLine("Menu");
                    Console.WriteLine("1. Implement Enter Operation");
                    Console.WriteLine("2. Implement Delete Operation");
                    Console.WriteLine("3. Display Values");
                    Console.WriteLine("4. Exit");
                    Console.WriteLine("\nEnter Your Choice (1-4): ");
                    ch = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine();
                    switch (ch)
                    {
                        case '1':
                            {
                                q.Enter();
                            }
                            break;
                        case '2':
                            {
                                q.Delete();
                            }
                            break;
                        case '3':
                            {
                                q.Display();
                            }
                            break;
                        case '4':
                            return;
                        default:
                            {
                                Console.WriteLine("Invalid Option!!");
                            }
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Check for the values Entered. ");
                }
            }
        }
    }
}