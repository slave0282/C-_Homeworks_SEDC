// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Console.WriteLine("Enter the first number: ");
var firstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number: ");
var secondNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the third number: ");
var thirdNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the fourth number: ");
var fourthNum = Convert.ToInt32(Console.ReadLine());
var result = (firstNum + secondNum + thirdNum + fourthNum) / 4;
Console.WriteLine("The average number is: " + result);
