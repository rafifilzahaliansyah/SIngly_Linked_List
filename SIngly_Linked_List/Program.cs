using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIngly_Linked_List
{
    class node
    {
        public int rollNumber;
        public string name;
        public node next;
    }

    class list
    {
        node START;
        public list()
        {
            START = null;
        }
        
        public void addnote()
        {
            int rollNo;
            string nm;
            Console.Write("\n Enter the roll number of the student: ");
            rollNo = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the roll number of the student: ");
            nm = Console.ReadLine();
            node newnode = new node();
        }
        
        
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
