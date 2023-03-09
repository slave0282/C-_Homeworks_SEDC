//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

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





