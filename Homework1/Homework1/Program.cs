//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System.Diagnostics;

Console.WriteLine("Enter two numbers");


double firstNumInput = double.Parse(Console.ReadLine());
double secondNumInput = double.Parse(Console.ReadLine());

Console.WriteLine("Enter the operation you would like to be executed(+,-,*,/)");

string operation = Console.ReadLine();

double result = 0;

switch (operation) 
{
    case "+":
        result = firstNumInput + secondNumInput; 
        break;
    case "-":
        result = firstNumInput - secondNumInput;
        break;
        case "*":
        result = firstNumInput * secondNumInput;
        break;
        case "/":
        result = firstNumInput / secondNumInput; 
        break;
        default:
        Console.WriteLine("Invalid operation");
        break;
}
Console.WriteLine("The result is " + result);

Console.WriteLine("Enter a number from 1-3");
string userInput = Console.ReadLine();
switch (userInput)
{
    case "1":
        Console.WriteLine("You got a new car");
        break;
    case "2":
        Console.WriteLine("You got a new plane");
        break;
    case "3":
        Console.WriteLine("You got a new bike");
        break;
    default:
        Console.WriteLine("You entered an invalid number");
        break;
}





