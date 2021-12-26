using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackArrayProject
{
    public class StackArray<T>
    {
        private T[] stackArray;
        private int top;
        public StackArray()
        {
            stackArray = new T[10];
            top = -1;
        }

        public StackArray(int maxSize)
        {
            stackArray = new T[maxSize];
            top = -1;
        }

        public int Size()
        {
            return top + 1;
        }

        public bool IsEmpty()
        {
            return top == -1;
        }
        public bool isFull()
        {
            return top == stackArray.Length - 1;
        }
        public void Push(T data)
        {
            if (isFull())
            {
                throw new InvalidOperationException("Stack overflow");
            }
            top += 1;
            stackArray[top] = data;
        }
        public T Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack Underflow");
            }
            var data = stackArray[top];
            top -= 1;
            return data;
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack Underflow");
            }
            return stackArray[top];
        }

        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack Empty");
                return;
            }
            for(int i = top; i >= 0; i--)
            {
                Console.WriteLine(stackArray[i] + " ");
            }
        }
    }
}
