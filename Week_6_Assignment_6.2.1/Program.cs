using System.ComponentModel;

namespace Week_6_Assignment_6._2._1
{
    internal class Program
    {
        //Write a C# program to implement a stack by using array with push and pop operations.
        static void Main(string[] args)
        {
            StackArr stackArr = new StackArr(10);

            Console.WriteLine("Will Push 6 elements into the stacks and remove the first one (LIFO)");
            stackArr.Push(1);
            stackArr.Push(2);
            stackArr.Push(3);
            stackArr.Push(4);
            stackArr.Push(5);
            stackArr.Push(6);
            stackArr.Pop();
            stackArr.Display();          
        }
    }
}
