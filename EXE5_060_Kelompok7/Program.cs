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
            newnode.data = value;
            if (Adrian == null)
            {
                Adrian = newnode();
                Rezha = newnode();
                return;
            }
            else
            {
                Adrian.next = newnode;
                Rezha.next = newnode;
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
            if (Adrian == null)
                Rezha = null;
        }
        
    }
}
