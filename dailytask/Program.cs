/*
Console.WriteLine("Enter 2 numbers");

double num1, num2, ans;

num1 = Convert.ToInt32(Console.ReadLine());
num2 = Convert.ToInt32(Console.ReadLine());

ans = num1 + num2;
Console.WriteLine(ans);

*/





/*
string? s1 = "";
string? s2 = "";

string s3;
s1 = Console.ReadLine();
s2 = Console.ReadLine();

s3 = s1 + "  " + s2;


Console.WriteLine(s1.Equals(s2));
Console.WriteLine(s1.ToUpper());
Console.WriteLine(s1.ToLower());

Console.WriteLine(s2.Substring(3));

string[] s = s3.Split(' ');
for (int i = 0; i < s.Length; i++)
    Console.WriteLine(s[i]);
*/
/*
string x = "5";
switch (x)

    case "1", "2":
    Console.WriteLine();
        break;
    case "2": Console.WriteLine();



} */

//driver
using Basic_Programs;


using System;

//Linear Search;



class LinearSearch
{
    public static int Search(int[] array, int target)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == target)
            {
                return i; // Element found at index i
            }
        }
        return -1; // Element not found
    }
}

class Program
{
    static void Main()
    {
        int[] data = { 10, 25, 7, 42, 15, 30, 8, 50, 5 };

        int target = 42;
        int result = LinearSearch.Search(data, target);

        if (result != -1)
        {
            Console.WriteLine($"Element {target} found at index {result}.");
        }
        else
        {
            Console.WriteLine($"Element {target} not found in the array.");
        }
    }
}

/*
Binary Search

using System;

class BinarySearch
{
    public static int Search(int[] arr, int target)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == target)
            {
                return mid; // Return the index of the target element if found
            }

            if (arr[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return -1; // Return -1 to indicate that the target element was not found
    }
}

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int target = 6;

        int result = BinarySearch.Search(arr, target);

        if (result != -1)
        {
            Console.WriteLine($"Element {target} found at index {result}");
        }
        else
        {
            Console.WriteLine($"Element {target} not found in the array");
        }
    }
}

===========================

Bubble sort

using System;

class BubbleSort
{
    public static void Sort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    // Swap arr[j] and arr[j + 1]
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }
}

class Program
{
    static void Main()
    {
        int[] arr = { 5, 1, 4, 2, 8 };
        
        Console.WriteLine("Original Array:");
        PrintArray(arr);

        BubbleSort.Sort(arr);

        Console.WriteLine("Sorted Array:");
        PrintArray(arr);
    }

    static void PrintArray(int[] arr)
    {
        foreach (var num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}

=========================

Insertion sort

using System;

class InsertionSort
{
    public static void Sort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 1; i < n; i++)
        {
            int key = arr[i];
            int j = i - 1;

            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j--;
            }

            arr[j + 1] = key;
        }
    }
}

class Program
{
    static void Main()
    {
        int[] arr = { 5, 1, 4, 2, 8 };
        
        Console.WriteLine("Original Array:");
        PrintArray(arr);

        InsertionSort.Sort(arr);

        Console.WriteLine("Sorted Array:");
        PrintArray(arr);
    }

    static void PrintArray(int[] arr)
    {
        foreach (var num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}

=====================

Merge sort

using System;

class MergeSort
{
    public static void Sort(int[] arr)
    {
        int n = arr.Length;
        if (n > 1)
        {
            int mid = n / 2;
            int[] left = new int[mid];
            int[] right = new int[n - mid];

            for (int i = 0; i < mid; i++)
            {
                left[i] = arr[i];
            }

            for (int i = mid; i < n; i++)
            {
                right[i - mid] = arr[i];
            }

            Sort(left);
            Sort(right);
            Merge(arr, left, right);
        }
    }

    private static void Merge(int[] arr, int[] left, int[] right)
    {
        int nL = left.Length;
        int nR = right.Length;
        int i = 0, j = 0, k = 0;

        while (i < nL && j < nR)
        {
            if (left[i] <= right[j])
            {
                arr[k] = left[i];
                i++;
            }
            else
            {
                arr[k] = right[j];
                j++;
            }
            k++;
        }

        while (i < nL)
        {
            arr[k] = left[i];
            i++;
            k++;
        }

        while (j < nR)
        {
            arr[k] = right[j];
            j++;
            k++;
        }
    }
}

class Program
{
    static void Main()
    {
        int[] arr = { 38, 27, 43, 3, 9, 82, 10 };

        Console.WriteLine("Original Array:");
        PrintArray(arr);

        MergeSort.Sort(arr);

        Console.WriteLine("Sorted Array:");
        PrintArray(arr);
    }

    static void PrintArray(int[] arr)
    {
        foreach (var num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}





//stack
class CustomStack<T>
{
    private T[] stackArray;
    private int top;
    private int maxSize;

    public CustomStack(int size)
    {
        maxSize = size;
        stackArray = new T[maxSize];
        top = -1;
    }

    public bool IsEmpty()
    {
        return top == -1;
    }

    public bool IsFull()
    {
        return top == maxSize - 1;
    }

    public void Push(T item)
    {
        if (IsFull())
        {
            Console.WriteLine("Stack is full. Cannot push.");
            return;
        }
        stackArray[++top] = item;
        Console.WriteLine($"Pushed: {item}");
    }

    public T Pop()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Stack is empty. Cannot pop.");
            return default(T);
        }
        T poppedItem = stackArray[top--];
        Console.WriteLine($"Popped: {poppedItem}");
        return poppedItem;
    }

    public T Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Stack is empty. Cannot peek.");
            return default(T);
        }
        return stackArray[top];
    }
}

class Program
{
    static void Main()
    {
        CustomStack<int> stack = new CustomStack<int>(5);

        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        var topItem = stack.Peek();
        Console.WriteLine($"Top item: {topItem}");

        stack.Pop();
        stack.Pop();
        stack.Pop();
        stack.Pop(); // Trying to pop from an empty stack

        stack.Push(4);
    }
}


/*
queue

using System;

class CustomQueue<T>
{
    private T[] queueArray;
    private int front;
    private int rear;
    private int maxSize;

    public CustomQueue(int size)
    {
        maxSize = size;
        queueArray = new T[maxSize];
        front = -1;
        rear = -1;
    }

    public bool IsEmpty()
    {
        return front == -1;
    }

    public bool IsFull()
    {
        return (rear == maxSize - 1 && front == 0) || (rear + 1 == front);
    }

    public void Enqueue(T item)
    {
        if (IsFull())
        {
            Console.WriteLine("Queue is full. Cannot enqueue.");
            return;
        }
        if (rear == maxSize - 1)
        {
            rear = 0;
        }
        else
        {
            rear++;
        }
        queueArray[rear] = item;

        if (front == -1)
        {
            front = 0;
        }
        Console.WriteLine($"Enqueued: {item}");
    }

    public T Dequeue()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Queue is empty. Cannot dequeue.");
            return default(T);
        }

        T dequeuedItem = queueArray[front];

        if (front == rear)
        {
            front = rear = -1;
        }
        else if (front == maxSize - 1)
        {
            front = 0;
        }
        else
        {
            front++;
        }
        Console.WriteLine($"Dequeued: {dequeuedItem}");
        return dequeuedItem;
    }
}

class Program
{
    static void Main()
    {
        CustomQueue<int> queue = new CustomQueue<int>(5);

        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);

        queue.Dequeue();
        queue.Dequeue();
        queue.Dequeue();
        queue.Dequeue(); // Trying to dequeue from an empty queue

        queue.Enqueue(4);
        queue.Enqueue(5);
    }
}

=====================================

LL

using System;

class Node<T>
{
    public T Data { get; set; }
    public Node<T> Next { get; set; }

    public Node(T data)
    {
        Data = data;
        Next = null;
    }
}

class CustomLinkedList<T>
{
    private Node<T> head;

    public CustomLinkedList()
    {
        head = null;
    }

    public bool IsEmpty()
    {
        return head == null;
    }

    public void AddNode(T data)
    {
        var newNode = new Node<T>(data);
        if (head == null)
        {
            head = newNode;
        }
        else
        {
            var current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
        Console.WriteLine($"Added: {data}");
    }

    public bool RemoveNode(T data)
    {
        if (IsEmpty())
        {
            Console.WriteLine("List is empty. Cannot remove.");
            return false;
        }

        if (head.Data.Equals(data))
        {
            head = head.Next;
            Console.WriteLine($"Removed: {data}");
            return true;
        }

        var current = head;
        while (current.Next != null)
        {
            if (current.Next.Data.Equals(data))
            {
                current.Next = current.Next.Next;
                Console.WriteLine($"Removed: {data}");
                return true;
            }
            current = current.Next;
        }
        Console.WriteLine($"Data not found: {data}");
        return false;
    }

    public void DisplayList()
    {
        if (IsEmpty())
        {
            Console.WriteLine("List is empty.");
            return;
        }

        var current = head;
        Console.Write("List: ");
        while (current != null)
        {
            Console.Write(current.Data + " ");
            current = current.Next;
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        CustomLinkedList<int> linkedList = new CustomLinkedList<int>();

        linkedList.AddNode(1);
        linkedList.AddNode(2);
        linkedList.AddNode(3);

        linkedList.RemoveNode(2);
        linkedList.RemoveNode(4); // Trying to remove a non-existent node

        linkedList.DisplayList();
    }
}

=======================

BT

using System;

class Node<T>
{
    public T Data { get; set; }
    public Node<T> Left { get; set; }
    public Node<T> Right { get; set; }

    public Node(T data)
    {
        Data = data;
        Left = null;
        Right = null;
    }
}

class CustomBinaryTree<T> where T : IComparable<T>
{
    private Node<T> root;

    public CustomBinaryTree()
    {
        root = null;
    }

    public void Insert(T data)
    {
        root = InsertNode(root, data);
        Console.WriteLine($"Inserted: {data}");
    }

    private Node<T> InsertNode(Node<T> node, T data)
    {
        if (node == null)
        {
            return new Node<T>(data);
        }

        if (data.CompareTo(node.Data) < 0)
        {
            node.Left = InsertNode(node.Left, data);
        }
        else if (data.CompareTo(node.Data) > 0)
        {
            node.Right = InsertNode(node.Right, data);
        }

        return node;
    }

    public void InorderTraversal()
    {
        Console.Write("Inorder Traversal: ");
        Inorder(root);
        Console.WriteLine();
    }

    private void Inorder(Node<T> node)
    {
        if (node != null)
        {
            Inorder(node.Left);
            Console.Write(node.Data + " ");
            Inorder(node.Right);
        }
    }

    public bool Search(T data)
    {
        return SearchNode(root, data);
    }

    private bool SearchNode(Node<T> node, T data)
    {
        if (node == null)
        {
            return false;
        }

        if (data.CompareTo(node.Data) == 0)
        {
            return true;
        }

        if (data.CompareTo(node.Data) < 0)
        {
            return SearchNode(node.Left, data);
        }

        return SearchNode(node.Right, data);
    }
}

class Program
{
    static void Main()
    {
        CustomBinaryTree<int> binaryTree = new CustomBinaryTree<int>();

        binaryTree.Insert(10);
        binaryTree.Insert(5);
        binaryTree.Insert(15);
        binaryTree.Insert(3);

        binaryTree.InorderTraversal();

        bool found = binaryTree.Search(15);
        Console.WriteLine("Search for 15: " + found);

        found = binaryTree.Search(7);
        Console.WriteLine("Search for 7: " + found);
    }
}

=====================

Traversal

using System;

class Node
{
    public int Data { get; set; }
    public Node Left { get; set; }
    public Node Right { get; set; }

    public Node(int data)
    {
        Data = data;
        Left = null;
        Right = null;
    }
}

class BinaryTree
{
    public Node Root { get; private set; }

    public BinaryTree()
    {
        Root = null;
    }

    public void Insert(int data)
    {
        Root = InsertRec(Root, data);
    }

    private Node InsertRec(Node root, int data)
    {
        if (root == null)
        {
            root = new Node(data);
            return root;
        }

        if (data < root.Data)
        {
            root.Left = InsertRec(root.Left, data);
        }
        else if (data > root.Data)
        {
            root.Right = InsertRec(root.Right, data);
        }

        return root;
    }

    public void InorderTraversal()
    {
        Console.Write("In-order Traversal: ");
        InorderRec(Root);
        Console.WriteLine();
    }

    private void InorderRec(Node root)
    {
        if (root != null)
        {
            InorderRec(root.Left);
            Console.Write(root.Data + " ");
            InorderRec(root.Right);
        }
    }

    public void PreorderTraversal()
    {
        Console.Write("Pre-order Traversal: ");
        PreorderRec(Root);
        Console.WriteLine();
    }

    private void PreorderRec(Node root)
    {
        if (root != null)
        {
            Console.Write(root.Data + " ");
            PreorderRec(root.Left);
            PreorderRec(root.Right);
        }
    }

    public void PostorderTraversal()
    {
        Console.Write("Post-order Traversal: ");
        PostorderRec(Root);
        Console.WriteLine();
    }

    private void PostorderRec(Node root)
    {
        if (root != null)
        {
            PostorderRec(root.Left);
            PostorderRec(root.Right);
            Console.Write(root.Data + " ");
        }
    }
}

class Program
{
    static void Main()
    {
        BinaryTree binaryTree = new BinaryTree();

        binaryTree.Insert(10);
        binaryTree.Insert(5);
        binaryTree.Insert(15);
        binaryTree.Insert(3);
        binaryTree.Insert(7);

        binaryTree.InorderTraversal();
        binaryTree.PreorderTraversal();
        binaryTree.PostorderTraversal();
    }
}









/*
public delegate void Delegate1(string message);
public delegate void Delegate2(int n1, int n2);
public delegate int Delegate3(int n1, int n2);
class Program 
{
    

    /*
public void delcall()
{
Delegate1 dobj1 = DelegateEx.MethodA;
dobj1.Invoke();
}*/
    /*
    public void Main(string[] args)
    {
        delcall();
    }
    */

    /*
    public static void Main(string[] args)
    {
        Delegate1 dobj1 = DelegateEx.MethodA;
        dobj1.Invoke();
    }
    */
    /*
    public static void Main(string[] args)
    {
        Delegate1 dobj1 = DelegateEx.MethodA;
        dobj1("Hello who r u ?");
    }
    */
    /*
    public static void Main(string[] args)
    {
        DelegateEx delegateEx = new();
        Delegate1 dobj1 = delegateEx.MethodA;
        dobj1("Hello who r u ?");
    }
    */
    /*
    public static void Main(string[] args)
    {
        //DelegateEx delegateEx = new();
        Delegate1 dobj1 = DelegateEx.MethodA;
        dobj1("Hello who r u ?");
    */
        /*
        DelegateEx delegateEx = new();
        Delegate2 dobj2 = delegateEx.Add;
        dobj2(10, 20);
        */
        /*
        DelegateEx delegateEx = new();
        Delegate2 dobj2 = delegateEx.Add;
        //dobj2(10, 20);
       
        Delegate2 dobj3 = delegateEx.Sub;
        //dobj3(10, 20);
        Delegate2 dobjallop = dobj2 + dobj3;
        dobjallop(10, 20);


        //Delegate3 dobjr = delegateEx.AddR;
        //Console.WriteLine( dobjr(10, 20));

    }
}
*/







/*
static void Swap<T>(ref T num1, ref T num2)
{
    T temp;
    temp = num1;
    num1 = num2;
    num2 = temp;
}




int n1 = 10, n2 = 20;
char c1 = 'A', c2 = 'B';

Swap<int>(ref n1,ref n2);
Swap<char>(ref c1, ref c2);

Console.WriteLine("a = {0}, b = {1}", n1, n2);
Console.WriteLine("c = {0}, d = {1}", c1, c2);
*/






//GenericEx<int> ga = new GenericEx<int>(new int[3] { 10, 20, 30 });
//GenericEx<int> ga = new (new int[3] { 10, 20, 30 });
//Console.WriteLine(ga.Arr);
//ga.Disp();

/*

GenericEx<int> g1 = new GenericEx<int>(10, 20);
Console.WriteLine(g1.Val1 + "  " + g1.Val2);

GenericEx<double> g2 = new GenericEx<double>(10.9887, 20.23456);
Console.WriteLine(g2.Val1 + "  " + g2.Val2);


GenericEx<string> g3 = new GenericEx<string>("Hi", "Hello !");
Console.WriteLine(g3.Val1 + "  " + g3.Val2);

GenericEx<bool> g4 = new GenericEx<bool>(true, false);
Console.WriteLine(g4.Val1 + "  " + g4.Val2);
*/







//FileOperations fo = new FileOperations();
//fo.CreateFile();
//fo.WriteData();
//fo.ReadData();
//fo.CopyMoveFile();
//fo.DeleteFile();
//fo.FileProperties();






/*using Basic_Programs.ExceptionMessages;

ExcepHandling excep = new ExcepHandling(10, 107);

try
{
    excep.NumCheck();
}
catch (Num1Exception ex)
{
    Console.WriteLine(ex.Message);
}
try
{
    excep.NumCheck2();
}
catch (Num2exception ex)
{
    Console.WriteLine(ex.Message);
}

/*
try
{
    excep.Divide();
}
catch (ArithmeticException ex)
{
    Console.WriteLine(MyExceptions.exmessageslist["Div 0"]);

}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine(MyExceptions.exmessageslist["IOR"]);
}
catch (Exception ex)
{
    Console.WriteLine(MyExceptions.exmessageslist["UE"]);
    
    
}
finally
{
    Console.WriteLine("Done");
}*/









//NonGenericCollections nonGenericCollections = new NonGenericCollections();
//nonGenericCollections.ArrayListHandling();
//nonGenericCollections.Stackhandling();
//nonGenericCollections.Queuehandling();
//nonGenericCollections.SLHandling();
//nonGenericCollections.HThandling();



//GenericCollections genericCollections = new GenericCollections();
//genericCollections.ListHandling();
//genericCollections.Stackhandling();
//genericCollections.Dicthandling();






//BankDetails bank = new (1234, 1234567890, "AA", "Inactive");
//BankDetails bank1 = new();
/*
BankDetailsNew bank2 = new(999, 9876543210, "BB", "Inactive");
bank2.WelcomeMessage();
//BankDetails.ExitMess();
//bank2.WelcomeMessage("Sambi");
Console.WriteLine("1. Custid 2. Accno 3. Name");
int ch = Convert.ToInt32(Console.ReadLine());

switch(ch)
{
    case 1:
        Console.WriteLine("Custid : ");
        bank2.GetAccDetails(Convert.ToInt32(Console.ReadLine()));
        break;
    case 2: Console.WriteLine("Accno : ");
        bank2.GetAccDetails(Convert.ToInt64(Console.ReadLine()));
        break;
    case 3: Console.WriteLine("Name : ");
        bank2.GetAccDetails(Console.ReadLine());
        break;
    default: Console.WriteLine("Enter bet 1-3");
        break;
}









/*
Doctor doc = new Doctor();
doc.AddNewDoctor(1234, "AA");
doc.DisplayDoctorDetails();
doc.ModifyDoctor(9876, "BB");
doc.DisplayDoctorDetails();
doc.BookApp(9876, "XX");
doc.DelApp("XX");






/*
Doctor doc = new Doctor();
doc.AddNewDoctor();
doc.DisplayDoctorDetails();
doc.ModifyDoctor();
doc.DisplayDoctorDetails();
*/










/*
EV ev = new();
ev.Vehnum = 555;
ev.Brand = "UST";
ev.Model = "123";
ev.Disp();
Console.WriteLine(ev.setTypeForVeh());

PV pv = new();
pv.Vehnum = 999;
pv.Brand = "TCS";
pv.Model = "516";
pv.Disp();
Console.WriteLine(pv.setTypeForVeh());
*/










/*
Console.WriteLine("1. TS 2. NTS");
switch(Convert.ToInt32(Console.ReadLine()))
{
    case 1:
        TeachingStaff ts = new TeachingStaff();
        ts.Staffid = 111;
        ts.name = "TS1";
        ts.Dept = "CS";
        ts.specializations = "OS, DBMS, DS";
        ts.sem = 4;
        ts.DisplayStaffDetails();
        ts.DsiplayTStaffDetails();
        break;
    case 2:
        NonTeachingStaff nts = new NonTeachingStaff();
        nts.Staffid = 111;
        nts.name = "NTS1";
        nts.Dept = "Admin";
        nts.Responsibilities = "Att, Sal";
        nts.Experience = 4;
        nts.DisplayStaffDetails();
        nts.DisplayNTStaffDetails();
        break;
}
*/







/*
StudentGrade grade = new();
grade.RollNo = 10000;
grade.StudentName = "AAA";
grade.Mark1 = 35;
grade.Mark2 = 87;
grade.Mark3 = 20;
grade.DisplayStudentDetails();
Console.WriteLine("Total" + grade.CalculateTotal());
Console.WriteLine("Average" + grade.CalculateAverage());
Console.WriteLine("Grade" + grade.CalculateGrade());
*/




/*
StudentMarks marks = new();
marks.RollNo = 10000;
marks.StudentName = "AAA";
marks.Mark1 = 99;
marks.Mark2 = 87;
marks.Mark3 = 97;
marks.DisplayStudentDetails();
Console.WriteLine("Total " + marks.CalculateTotal());
Console.WriteLine("Average" + marks.CalculateAverage());
*/


/*
ArraysEx arraysEx = new();
arraysEx.Ja();






/*
Employee employee = new(111, "AA", "IT", 10000);
Console.WriteLine("Emp Id : {0} \n" + "Name : {1} \n" + "Dept : {2} \n" + "Basic Pay : {3}", employee.Eid, employee.Ename, employee.Dept, employee.Basicpay);
Console.WriteLine("Net Pay : {0}", employee.CalculateSalary());
*/








/*
int consumernumber = Convert.ToInt32(Console.ReadLine());
string? consumername = Console.ReadLine();
int prevreading = Convert.ToInt32(Console.ReadLine());
int currreading = Convert.ToInt32(Console.ReadLine());

Electricity electricity1 = new Electricity (consumernumber, prevreading, currreading, consumername);
Console.WriteLine("Con Num : " + electricity1.consumernumber);
Console.WriteLine("Con Name : " + electricity1.consumername);
Console.WriteLine("Bill Amt : " + electricity1.CalculateBill());
Electricity electricity2 = new(23456, 9000, 10000, "SS");
Console.WriteLine(electricity2.consumernumber);
Console.WriteLine(electricity2.consumername);
Console.WriteLine(electricity2.CalculateBill());
*/







/*
Calculation calculation = new Calculation();
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());

double res = calculation.Add(num1, num2);
Console.WriteLine(res);
*/



