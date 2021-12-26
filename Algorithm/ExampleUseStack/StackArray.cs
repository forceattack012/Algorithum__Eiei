using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleUseStack
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
        public bool IsEmpty()
        {
            return top == -1;
        }
        public bool IsFull()
        {
            return top == stackArray.Length - 1;
        }

        public void Push(T value)
        {
            if (IsFull())
            {
                throw new InvalidOperationException("Stack Overflow");
            }
            top += 1;
            stackArray[top] = value;
        }
        public T Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack underflow");
            }
            var value = stackArray[top];
            top -= 1;
            return value;
        }
        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack underflow");
            }
            return stackArray[top];
        }
    }
}
