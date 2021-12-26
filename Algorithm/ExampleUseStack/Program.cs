// See https://aka.ms/new-console-template for more information
using ExampleUseStack;

Console.WriteLine("Hello, World!");


ValidParenthese validParenthese = new ValidParenthese();
var x = validParenthese.IsValid("(([]){})");

x = validParenthese.IsValid("(8+2)/(7)");
