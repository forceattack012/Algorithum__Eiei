// See https://aka.ms/new-console-template for more information
using RecursionProject;

Console.WriteLine("Hello, World!");

Recursion recursion = new Recursion();
//recursion.Print1(100); // order desc
recursion.Print2(100); //order asc


var fac = recursion.Factorial(3);
Console.WriteLine("Fac is : " + fac);

var sum = recursion.Summation(5); //1+2+3+4+5 = 15
Console.WriteLine("Sumation is : " + sum);


var sumDigit = recursion.SumDigit(56432); //5+6+4+3+2 = 20
Console.WriteLine("Sum Digit is : " + sumDigit);

recursion.ToBinary(13);


var pow = recursion.Power(10, 3); // 1000
Console.WriteLine("Power is : " + pow);
var fib = recursion.Fibonacci(5);
Console.WriteLine("Fib is : " + fib);


var c = recursion.Count(6420); //4

Console.WriteLine("C is : " + c);