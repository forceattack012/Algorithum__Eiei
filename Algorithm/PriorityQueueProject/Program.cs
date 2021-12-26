// See https://aka.ms/new-console-template for more information
using PriorityQueueProject;

Console.WriteLine("Hello, World!");

PriorityQueue priority = new PriorityQueue();
priority.Insert(1, 4);
priority.Insert(2, 3);
priority.Insert(3, 5);
priority.Insert(0, 1);
priority.Insert(10, 2);
priority.Display();
