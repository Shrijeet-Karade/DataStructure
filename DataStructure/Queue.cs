using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class Queue : Interface1
    {
        int front, rear, size;
        int capacity;
        int [] arrayQueue;

        public Queue()
        {

        }
        public Queue (int capacity)
        {
            //
            this.capacity = capacity;
            //
            front = this.size = 0; 
            //
            rear = capacity - 1;
            //
            arrayQueue = new int[this.capacity];
            
        }
        public int AddNewElement(int x)
        {
            //
            if (IsFull(this))
            { 
                return 1;
            }
            //
            this.rear = (this.rear + 1) % this.capacity;
            //
            this.arrayQueue[this.rear] = x;
            //
            this.size = this.size + 1;
            
            Console.WriteLine(x + " added ");
            return 0;
        }
        public int RemoveElement()
        {
            if (IsEmpty(this))
                return int.MaxValue;
            //
            int x = this.arrayQueue[this.front];
            //
            this.front = (this.front + 1) % this.capacity;
            //
            this.size = this.size - 1;
            //
            return x;
        }
        public void Sort()
        {
            //implementing bubble sort
            int n = arrayQueue.Length;

            // checking i index  element
            for (int i= 0; i < n - 1; i++)
            {   
                // j index element
                for (int j = 0; j < n - i - 1; j++)
                {   
                    // comparing and swapping if a[j]>a[i]
                    if (arrayQueue[j] > arrayQueue[j + 1])
                    {
                        // sorting by swapping of numbers
                        int temporaryVariable = arrayQueue[j];
                        arrayQueue[j] = arrayQueue[j + 1];
                        arrayQueue[j + 1] = temporaryVariable;
                    }
                }
            }
            //printing the queue
            Display();
                       
        }
        
        public void Peek()
        {
            Console.WriteLine(Front());

        }
        public int Front()
        {
            if (IsEmpty(this))
                return int.MinValue;

            return this.arrayQueue[this.front];
        }

        // Method to get rear of queue
        public int Rear()
        {
            if (IsEmpty(this))
                return int.MinValue;

            return this.arrayQueue[this.rear];
        }
        // checking if Queue is full
        public bool IsFull(Queue object1)
        {
            return (object1.size == object1.capacity);
        }
        // checking if Queue is empty
        public bool IsEmpty(Queue object1)
        {
            return (object1.size == 0);
        }
        public void Display()
        {
            int index = this.arrayQueue.Length;
            for (int i = 0; i < index; ++i)
                Console.Write(this.arrayQueue[i] + " ");
            Console.WriteLine();
        }
    }
}
