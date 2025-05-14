using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_6_Assignment_6._2._1
{
    internal class StackArr
    {
        private int[] data;
        private int top;

        public StackArr(int size)
        {
            data = new int[size];
            top = -1;
        }

        public bool IsEmpty()
        {
            return this.top == -1;
        }

        public bool IsFull()
        {
            return this.top == data.Length -1;
        }
        public void Push(int val)
        {
            if (IsFull()) { 
                Console.WriteLine("Stack is full"); 
                return; 
            }
            else { 
                top++; 
                data[top] = val; 
            }         
        }

        public int Pop()
        {
            if (IsEmpty()) {
                
                Console.WriteLine("Stack is empty");
                return -1;
            }
            int val = data[top]; 
            top--; 
            return val; 
        }

        public void Display()
        {
            if (!IsEmpty())
            {
                for (int i = top; i >= 0; i--)
                {
                    Console.WriteLine(data[i]);
                }
            }
            else
            {
                Console.WriteLine("Empty");
            }
        }       
    }
}

