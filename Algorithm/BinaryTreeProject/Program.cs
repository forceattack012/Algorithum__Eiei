// See https://aka.ms/new-console-template for more information
using BinaryTreeProject;

Console.WriteLine("Hello, World!");

BinaryTree binaryTree = new BinaryTree();
binaryTree.Create();
binaryTree.Display();
Console.WriteLine("\nHeight : " + binaryTree.Height());

Console.WriteLine("PreOrder : \n");
binaryTree.PreOrder();
Console.WriteLine("InOrder : \n");
binaryTree.InOrder();

Console.WriteLine("PostOrder : \n");
binaryTree.PostOrder();

Console.WriteLine("LevelOrder : \n");
binaryTree.LevelOrder();