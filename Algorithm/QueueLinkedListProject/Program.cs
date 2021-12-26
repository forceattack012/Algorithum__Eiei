// See https://aka.ms/new-console-template for more information
using QueueLinkedListProject;

Console.WriteLine("Hello, World!");

QueueLinkedList QueueLinkedListProject = new QueueLinkedList();

QueueLinkedListProject.Enqueue(10);
QueueLinkedListProject.Enqueue(30);
QueueLinkedListProject.Enqueue(40);
QueueLinkedListProject.Dequeue();
QueueLinkedListProject.Display();