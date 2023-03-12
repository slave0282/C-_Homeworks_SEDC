//// See https://aka.ms/new-console-template for more information
////Console.WriteLine("Hello, World!");


//Task 1:
//Create new console application “SwapNumbers”. Input 2 numbers from the console and then swap the values of the variables so that the first variable has the second value and the second variable the first value. Please find example below:



Console.WriteLine("Enter a number: ");
var firstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter another number: ");
var secondNum = Convert.ToInt32(Console.ReadLine());
int reverseNum = firstNum;
firstNum = secondNum;
secondNum = reverseNum;
int[] inputArray = { firstNum, secondNum };
Console.WriteLine(inputArray[0]);
Console.WriteLine(inputArray[1]);
