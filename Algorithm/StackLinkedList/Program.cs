// See https://aka.ms/new-console-template for more information

using StackLinkedList;

IStackL<int> stackL = new StackL<int>();
stackL.Push(0);
stackL.Push(1);
stackL.Push(2);
stackL.Pop();
stackL.Display();

Console.WriteLine(stackL.Peek());

Console.WriteLine("Hello, World!");
