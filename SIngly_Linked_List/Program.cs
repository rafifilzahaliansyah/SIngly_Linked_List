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
            newnode.rollNumber = rollNo;
            newnode.name = nm;
            if((START == null) || (rollNo <= START.rollNumber))
            {
                if((START != null) && (rollNo == START.rollNumber))
                {
                    Console.WriteLine();
                    return;
                }
                newnode.next = START;
                START = newnode;
                return;
            }

            node previous, current;
            previous = START;
            current = START;

            if ((current != null) && (rollNo == current.rollNumber))
            {
                if (rollNo == current.rollNumber)
                {
                    Console.WriteLine();
                    return;
                }
                previous.next = current;
                previous.next = newnode;
            }
            previous.next = current;
            previous.next = newnode;
        }

        public bool delNode(int rollno)
        {
            node previous, current;
            previous = current = null;
            if (search(rollno, ref previous, ref current) == false)
                return false;
            previous.next = current.next;
            if (current == START)
                START = START.next;
            return true;

        }
        
        public bool search(int rollNo, ref node previous, ref node current)
        {
            previous = START;
            current = START;
            while ((current != null) && (rollNo == current.rollNumber))
            {
                previous = current;
                current = current.next;
            }
            if (current == null)
                return false;
            else
                return true;
        }
        public void Treverse()
        {
            if (listEmpty())
                Console.WriteLine("\nThe record in the list are : ");
            else
            {
                Console.WriteLine("\nThe record in the list are : ");
                node currentNode;
                for (currentNode = START; currentNode != null;
                    currentNode = currentNode.next)
                    Console.Write(currentNode.rollNumber + " "
                        + currentNode.name + "\n");
                Console.WriteLine();
            }

        }

        public bool listEmpty()
        {
            if (START == null)
                return true;
            else
                return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            list obj = new list();
            while(true)
            {
                try
                {
                    Console.WriteLine("\nMenu");
                    Console.WriteLine("1. Add a record to the list");
                    Console.WriteLine("2. Delete a Record from the list");
                    Console.WriteLine("3. View all the record  in the list");
                    Console.WriteLine("4. Search for a record in the list");
                    Console.WriteLine("5. Exit");
                    Console.Write("\n enter your choice (1-5) : ");
                    char ch = Convert.ToChar(Console.ReadLine());

                    switch(ch)
                    {
                        case '1':
                            {
                                obj.addnote();
                            }
                            break;

                        case '2':
                            {
                                if (obj.listEmpty())
                                {
                                    Console.WriteLine("\nlist is empty");
                                    break;
                                }
                                Console.WriteLine("enter the roll number of" +
                                    "the student whose record is to be deleted : ");
                                int rollNo = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine();
                                if (obj.delNode(rollNo) == false)
                                    Console.WriteLine("record with roll number" +
                                        +rollNo + "deleted");
                            }
                            break;

                        case '3':
                            {
                                obj.Treverse();
                            }
                            break;

                        case '4':
                            {
                                if(obj.listEmpty())
                                {
                                    Console.WriteLine("\nlist empty");
                                    break;
                                }
                                node previous, current;
                                previous = current = null;
                                Console.Write("\nenter the roll number of the" +
                                    "student whole record is to be searched : ");
                                int num = Convert.ToInt32(Console.ReadLine());
                                if (obj.search(num, ref previous, ref current) == false)
                                    Console.WriteLine("\nRecord not found");
                                else
                                {
                                    Console.WriteLine("\nrecord not found");
                                    Console.WriteLine("\nroll number : "+ current.rollNumber);
                                    Console.WriteLine("\nname : " + current.name);
                                }
                            }
                            break;
                        case '5':
                            return;
                        default:
                            {
                                Console.WriteLine("\ninvalid option");
                                break;
                            }
                    }
                }
                catch(Exception)
                {
                    Console.WriteLine("\nCheck for the value entered");
                }
            }
        }
    }
}
