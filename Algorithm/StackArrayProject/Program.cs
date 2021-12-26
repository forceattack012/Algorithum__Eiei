// See https://aka.ms/new-console-template for more information

using StackArrayProject;

StackArray<int> stackArray = new StackArray<int>(4);
StackArray<string> StackArray1 = new StackArray<string>(4);
stackArray.Push(1);
stackArray.Push(2);
stackArray.Push(3); 
stackArray.Push(4);

stackArray.Pop();
stackArray.Pop();
stackArray.Display();
Console.WriteLine("Hello, World!");
