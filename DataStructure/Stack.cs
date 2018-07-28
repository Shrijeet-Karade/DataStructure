using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class Stack : Interface1
    {

        int top;
        int[] stackArray = new int[20];

        public Stack()
        {
            top = -1;
        }
        public int AddNewElement(int x)
        {
            if (this.top >= 20)
            {
                Console.WriteLine("Stack Overflow");
                return 0;
            }
            else
            {
                this.stackArray[++top] = x;
                return 1;
            }
        }
        public int RemoveElement()
        {
            if (this.top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return 0;
            }
            else
            {
                int value = this.stackArray[top--];
                return value;
            }


        }
        bool IsEmpty()
        {
            return (top < 0);
        }
        public void Sort()
        {
            // sorting Stack


        }
        public void Display()
        {
            if (this.top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }
            else
            {
                Console.WriteLine("Items in the Stack are :");
                for (int i = this.top; i >= 0; i--)
                {
                    Console.WriteLine(this.stackArray[i]);
                }
            }
        }
    }
}


