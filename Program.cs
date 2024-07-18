using System;

namespace Data_structure
{
    //class Node
    //{
    //    public int data;
    //    public Node next;
    //}
    //class LinkedList
    //{
    //    Node head;
    //    int count;
    //    public LinkedList()
    //    {
    //        count = 0;

    //    }
    //    public void insertFirst(int value)
    //    {

    //        Node temp = new Node();
    //        temp.data = value;
    //        temp.next = head;
    //        head = temp;
    //        count++;

    //    }
    //    public void insertLast(int value)
    //    {
    //        Node temp = new Node();
    //        temp.data = value;
    //        Node p = head;
    //        while (p.next != null)
    //            p = p.next;
    //        p.next = temp;
    //        count++;

    //    }
    //    public void insertAfterNode(int x, int value)
    //    {
    //        //insert node after node having value X 
    //        Node temp = new Node();
    //        temp.data = value;
    //        Node p = head;
    //        bool found = false;
    //        while (p != null)
    //        {
    //            if (p.data == x)
    //            {
    //                found = true;
    //                break;
    //            }
    //            p = p.next;

    //        }
    //        if (found)
    //        {
    //            temp.next = p.next;
    //            p.next = temp;
    //            count++;

    //        }
    //        else
    //        {
    //            Console.WriteLine("not exsits");
    //        }


    //    }
    //    public void insertBeforeNode(int x, int value)
    //    {
    //        //insert node before node having value X 
    //        Node temp = new Node();
    //        temp.data = value;                                        //single linkedlist
    //        Node p = head;
    //        bool found = false;

    //        while (p.next != null)
    //        {
    //            if (p.next.data == x)
    //            {
    //                found = true;
    //                break;
    //            }
    //            p = p.next;

    //        }
    //        if (found)
    //        {
    //            temp.next = p.next;
    //            p.next = temp;
    //            count++;

    //        }
    //        else
    //        {
    //            Console.WriteLine("not exsits");
    //        }


    //    }
    //    public void insertAt(int index, int value)
    //    {
    //        Node temp = new Node();
    //        temp.data = value;
    //        Node p = head;
    //        for (int i = 0; i < index - 1 && p != null; i++)
    //        {
    //            p = p.next;
    //        }
    //        temp.next = p.next;
    //        p.next = temp;
    //        count++;

    //    }
    //    public void PrintList()
    //    {
    //        Node p = head;

    //        while (p != null)
    //        {
    //            Console.WriteLine(p.data);
    //            p = p.next;
    //        }
    //    }
    //    public void search(int value)
    //    {
    //        int position = 1;
    //        Node p = head;
    //        while (p != null)
    //        {
    //            if (p.data == value)
    //                break;
    //            position++;
    //            p = p.next;
    //        }
    //        if (p == null)
    //        {
    //            Console.WriteLine("Not found");
    //        }
    //        else
    //        {
    //            Console.WriteLine("found at" + position);
    //        }
    //    }
    //    public int getCount() { return count; }
    //}




    //__________________________________________________________________________________________________________




    //class Node
    //{
    //    public int data;
    //    public Node next;
    //    public Node prev;
    //}
    //class List
    //{
    //    public int coun;
    //    public Node head;
    //    public List()
    //    {
    //        head = null;
    //        coun = 0;
    //    }
    //    public void add_front(int item)
    //    {
    //        Node temp = new Node();
    //        temp.data = item;
    //        temp.next = head;
    //        head.prev = temp;
    //        temp.prev = null;
    //        head = temp;
    //        coun++;
    //    }
    //    public void add_back(int item)
    //    {
    //        Node temp = new Node();
    //        temp.data = item;
    //        if (head == null)
    //        {
    //            head = temp;
    //        }
    //        else
    //        {
    //            Node p = head;
    //            while (p.next != null)
    //            {
    //                p = p.next;
    //            }
    //            p.next = temp;
    //            temp.prev = p;
    //            temp.next = null;
    //            coun++;
    //        }
    //    }
    //    public void insert_after_value(int item, int search)
    //    {
    //        Node p = head;
    //        while (p.data != search)
    //        {
    //            p = p.next;
    //        }
    //        if (p.next == null)
    //        {
    //            add_back(item);
    //        }
    //        else
    //        {
    //            Node temp = new Node();
    //            temp.data = item;
    //            temp.prev = p;
    //            temp.next = p.next;
    //            p.next.prev = temp;
    //            p.next = temp;
    //            coun++;
    //        }
    //    }
    //    public void insert_before_value(int item, int search)
    //    {
    //        Node p = head;
    //        while (p.data != search)
    //        {
    //            p = p.next;
    //        }
    //        Node temp = new Node();
    //        temp.data = item;
    //        temp.prev = p.prev;
    //        temp.next = p;
    //        p.prev.next = temp;
    //        p.prev = temp;
    //        coun++;
    //    }
    //    public void insert_in_position(int item, int pos)
    //    {
    //        Node p = head;
    //        int p1 = 1;
    //        while (p1 != pos)
    //        {
    //            p = p.next;
    //            p1++;

    //        }
    //        Node temp = new Node();
    //        temp.data = item;
    //        temp.prev = p.prev;
    //        temp.next = p;
    //        p.prev.next = temp;
    //        p.prev = temp;
    //        coun++;
    //    }
    //    public void search(int item)
    //    {
    //        Node p = head;
    //        bool found = false;
    //        while (p.next != null)
    //        {
    //            if (item == p.data)
    //            {
    //                found = true;
    //                break;
    //            }
    //            p = p.next;
    //        }
    //        if (found)
    //            Console.WriteLine("Found {0} in the linkedlist ", item);
    //        else
    //            Console.WriteLine("Not found in the linked list ");
    //    }
    //    public void delete_in_position(int pos)
    //    {
    //        Node p = head;
    //        int p1 = 1;
    //        while (p1 < pos)
    //        {
    //            p = p.next;
    //            p1++;
    //        }
    //        p.prev.next = p.next;
    //        p.next.prev = p.prev;
    //        p.next = null;
    //        p.prev = null;
    //        coun--;
    //    }
    //    public void delete_by_item(int item)
    //    {
    //        Node p = head;
    //        int p2 = 1;
    //        if (p.data == item)
    //        {
    //            delete_front();
    //        }
    //        else
    //        {
    //            while (p.data != item)
    //            {
    //                p = p.next;
    //                p2++;
    //            }
    //            delete_in_position(p2);
    //        }
    //        coun--;
    //    }
    //    public void delete_last()
    //    {
    //        Node p = head;
    //        while (p.next.next != null)
    //        {
    //            p = p.next;
    //        }
    //        p.prev.next = null;
    //        coun--;
    //    }
    //    public void delete_front()
    //    {
    //        if (head.next == null)
    //        {
    //            head = null;
    //        }
    //        else
    //        {
    //            head = head.next;
    //            head.prev = null;
    //            coun--;
    //        }
    //    }
    //    public void reverse()
    //    {
    //        Node current = head, odam = current.next;
    //        current.next = null;
    //        current.prev = odam;
    //        while (odam != null)
    //        {
    //            odam.prev = odam.next;
    //            odam.next = current;
    //            current = odam;
    //            odam = odam.prev;
    //        }
    //        head = current;

    //    }
    //    public void print()
    //    {
    //        Node p = head;
    //        while (p.next != null)
    //        {
    //            Console.Write(p.data + " ");
    //            p = p.next;
    //        }
    //        Console.Write(p.data + "\n");
    //    }
    //    public void size()
    //    {
    //        Console.WriteLine("LinkedList size = {0}", coun);
    //    }
    //}

    //___________________________________________________________________________________________________________



    //class stack //using array
    //{
    //    public int top;
    //    public int[] arr;
    //    public stack()
    //    {
    //        top = -1;
    //    }
    //    public void get_array(int size)
    //    {
    //        while (size < 1)
    //        {
    //            Console.WriteLine("Enter Valid Size = ");
    //            size = int.Parse(Console.ReadLine());
    //            get_array(size);
    //        }
    //        arr = new int[size];
    //    }
    //    public bool is_empty()
    //    {
    //        return top < 0;
    //    }
    //    public bool is_full()
    //    {
    //        return top == arr.Length - 1;
    //    }
    //    public void push(int n)
    //    {
    //        if (is_full())
    //            Console.WriteLine("Stack Overflow!");
    //        else
    //        {
    //            top++;
    //            arr[top] = n;
    //        }

    //    }
    //    public void pop()
    //    {
    //        if (is_empty())
    //            Console.WriteLine("Stack Underflow!");
    //        else
    //        {
    //            Console.WriteLine("Pop : " + arr[top]);
    //            top--;
    //        }
    //    }
    //    public void peek()
    //    {
    //        if (is_empty())
    //            Console.WriteLine("Stack is empty!");
    //        else
    //            Console.WriteLine("the top element in the stack is " + arr[top]);
    //    }
    //    public int size()
    //    {
    //        if (is_empty())
    //        {
    //            Console.WriteLine("Stack is empty!");
    //            return 0;
    //        }
    //        else
    //            return top + 1;
    //    }
    //    public void display()
    //    {
    //        if (is_empty())
    //            Console.WriteLine("Stack is empty!");
    //        else
    //        {
    //            for (int i = top; i >= 0; i--)
    //                Console.Write(arr[i] + " ");
    //            Console.WriteLine();
    //        }
    //    }
    //}



    //________________________________________________________________________________________________________


    //class Queue //queue using array
    //{
    //    public int head, rear;
    //    int[] arr;
    //    public Queue(int size)
    //    {
    //        head = rear = -1;
    //        arr = new int[size];
    //    }
    //    public bool is_full()
    //    {
    //        return rear == arr.Length - 1;
    //    }
    //    public void enqueue(int n)
    //    {
    //        if (is_full())
    //            Console.WriteLine("Queue is full!");
    //        else
    //        {
    //            if (head == -1)
    //            {
    //                head = 0;
    //            }
    //            rear++;
    //            arr[rear] = n;
    //        }
    //    }
    //    public bool is_empty()
    //    {
    //        if (rear == -1 || rear < head)
    //        {
    //            return true;
    //        }
    //        return false;
    //    }
    //    public void dequeue()
    //    {
    //        if (is_empty())
    //            Console.WriteLine("Queue is empty!");
    //        else
    //            Console.WriteLine("dequeue : " + arr[head++]);
    //    }
    //    public void peek()
    //    {
    //        if (is_empty())
    //            Console.WriteLine("Queue is empty!");
    //        else
    //            Console.WriteLine("peeking at : " + arr[head]);
    //    }
    //    public void size()
    //    {
    //        Console.WriteLine("size = " + (rear - head + 1));
    //    }
    //    public void display()
    //    {
    //        if (is_empty())
    //            Console.WriteLine("Queue is empty!");
    //        else
    //        {
    //            for (int i = head; i <= rear; i++)
    //            {
    //                Console.Write(arr[i] + " ");
    //            }
    //            Console.WriteLine();
    //        }

    //    }
    //}



    //________________________________________________________________________________________________________



    //class Node
    //{
    //    public int data;
    //    public Node next;
    //}
    //class List
    //{
    //    public Node head, rear;
    //    public List()
    //    {
    //        head = rear = null;
    //    }
    //    public void enqueue(int item)
    //    {
    //        Node temp = new Node();
    //        temp.data = item;
    //        if (head == null)
    //        {
    //            head = rear = temp;
    //        }
    //        else
    //        {
    //            rear.next = temp;
    //            rear = temp;
    //            temp.next = null;
    //        }
    //    }
    //    public void dequeue()
    //    {
    //        if (is_empty())
    //            Console.WriteLine("Empty queue!");
    //        else
    //        {
    //            Console.WriteLine("dequeue : " + head.data);
    //            head = head.next;
    //        }
    //    }
    //    public bool is_empty()
    //    {
    //        return head == null;
    //    }
    //    public void display()
    //    {
    //        Node p = head;
    //        while (p.next != null)
    //        {
    //            Console.Write(p.data + " ");
    //            p = p.next;
    //        }
    //        Console.Write(p.data + "\n");
    //    }
    //    public void peek()
    //    {
    //        if (is_empty())
    //            Console.WriteLine("Empty queue!");
    //        else
    //            Console.WriteLine("peek at : " + head.data);
    //    }
    //    public void size()
    //    {
    //        Node p = head;
    //        int coun = 1;
    //        while (p != rear)
    //        {
    //            coun++;
    //            p = p.next;
    //        }
    //        Console.WriteLine("LinkedList size = {0}", coun);
    //    }
    //}

    class Program
    {
        static void Main(string[] args)
        {
            //LinkedList list = new LinkedList();
            //list.insertFirst(1);
            //list.insertFirst(1);
            //list.insertFirst(1);
            //list.insertFirst(1);                    //single linkedlist
            //list.insertLast(5);
            //list.insertAfterNode(5, 9);
            //list.insertAt(1, 12);
            //list.PrintList();



            //__________________________________________________________________________________________________________





            //List L = new List();
            //L.add_back(10);
            //L.add_back(11);
            //L.add_back(12);
            //L.add_front(13);
            //L.add_front(14);
            //L.add_back(15);
            ////L.delete_by_item(14);
            ////L.size();
            ////L.insert_after_value(999, 15);
            ////L.insert_in_position(999, 3);
            ////L.insert_before_value(919, 10);             //double linkedlist
            ////L.reverse();
            ////L.size();
            ////L.delete_in_position(2);
            ////L.delete_last();
            ////L.delete_last();
            ////L.delete_front();
            ////L.size();
            ////L.delete_front();
            //L.print();
            ////L.search(919);
            ////L.size();
            ///



            //________________________________________________________________________________________________-




            //stack L = new stack();
            //Console.WriteLine("Enter the size of stack :");
            //int size = int.Parse(Console.ReadLine());
            //L.get_array(size);
            //if (L.is_empty())
            //{ Console.WriteLine("Empty Stack"); }
            //L.push(10);
            //L.push(11);
            //L.push(12);
            //L.push(13);
            //L.push(14);
            //L.push(15);
            //L.peek();
            //Console.WriteLine("size = " + L.size());                  //stack using array
            //L.pop();
            //L.pop();
            //L.pop();
            //L.is_empty();
            //L.push(10);
            //L.push(11);
            //L.push(12);
            //L.push(10);
            //L.push(11);
            //L.push(12);
            //L.display();


            //________________________________________________________________________________________________



            //Console.WriteLine("Enter the size : ");
            //int size = int.Parse(Console.ReadLine());
            //Queue L = new Queue(size);
            //L.enqueue(10);//10
            //L.enqueue(11);//10 11
            //L.enqueue(12);//10 11 12
            //L.enqueue(13);//10 11 12 13
            //L.enqueue(14);//10 11 12 13 14
            //L.display();//10 11 12 13 14
            //L.dequeue();//10 - > 11 12 13 14
            //L.size();//4                                            //queue using array
            //Console.WriteLine(L.is_empty());//false
            //Console.WriteLine(L.is_full());//false
            //L.dequeue();//11 - > 12 13 14
            //L.dequeue();//12 - > 13 14
            //L.dequeue();//13 - > 14
            //L.dequeue();//13 - >
            //L.dequeue();//empty!
            //L.dequeue();//empty!


            //____________________________________________________________________________________________________


            //List L = new List();
            //L.enqueue(10);//10
            //L.enqueue(11);//10 11
            //L.enqueue(12);//10 11 12
            //L.enqueue(13);//10 11 12 13
            //L.enqueue(14);//10 11 12 13 14
            //L.enqueue(15);//10 11 12 13 14 15
            //L.display();//10 11 12 13 14 15 
            //L.dequeue();//11 12 13 14 15
            //L.dequeue();//12 13 14 15
            //L.dequeue();//13 14 15
            //L.peek();//13
            //L.size();//3
            //L.display();//13 14 15
            //L.dequeue();//14 15
            //L.dequeue();//15 
            //L.dequeue();//
            //L.dequeue();// empty!!!
        }
    }
}
