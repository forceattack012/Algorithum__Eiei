using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackLinkedList
{
    public interface IStackL<T>
    {
        void Push(T data);
        T Pop();
        bool IsEmpty();
        int Size();
        void Display();
        T Peek();
    }
}
