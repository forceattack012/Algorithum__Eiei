// See https://aka.ms/new-console-template for more information
using QueueArrayProject;

Console.WriteLine("Hello, World!");

QueueArray queueArray = new QueueArray(5);
queueArray.Enqueue(1);
queueArray.Enqueue(2);
queueArray.Enqueue(3);
queueArray.Enqueue(4);
queueArray.Dequeue();
queueArray.Dequeue();
Console.WriteLine("Size : " + queueArray.Size());
queueArray.Display();
