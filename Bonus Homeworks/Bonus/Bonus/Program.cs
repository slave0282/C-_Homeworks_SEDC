////Bonus 5th exercise from Class03

////● Declare a new array of integers with 5 elements
////● Initialize the array elements with values from input
////● Sum all the values and print the result in the console



//int[] arrayOfInts = new int[5];
//Console.WriteLine("Enter 5 numbers: ");
//int firstNum = Convert.ToInt32(Console.ReadLine());
//int secondNum =  Convert.ToInt32(Console.ReadLine());
//int thirdNum = Convert.ToInt32(Console.ReadLine());
//int fourthNum = Convert.ToInt32(Console.ReadLine());
//int fifthNum = Convert.ToInt32(Console.ReadLine());
//arrayOfInts[0] = firstNum;
//arrayOfInts[1] = secondNum;
//arrayOfInts[2] = thirdNum;
//arrayOfInts[3] = fourthNum;
//arrayOfInts[4] = fifthNum;
//int sumOfNums = 0;
//for (int i = 0; i < arrayOfInts.Length; i++)
//{
//    sumOfNums += arrayOfInts[i];
//}
//Console.WriteLine("The sum of the numbers in the array is: "+sumOfNums);

////Bonus sixth exercise from Class03
//● Create an array with names
//● Give an option to the user to enter a name from the keyboard
//● After entering the name put it in the array
//● Ask the user if they want to enter another name(Y / N)
//● Do the same process over and over until the user enters N
//● Print all the names after user enters N

string[] namesArray = new string[50];//Brojot na elementi vo nizata e ogranicen na 50
int counter = 0;

while (true)
{
    Console.WriteLine("Enter a name: ");
    string name = Console.ReadLine();
    namesArray[counter] = name;
    counter++;

    Console.WriteLine("If you want to enter another name enter Y, otherwise enter N");
    string userResponse = Console.ReadLine();
    if (userResponse.ToUpper() == "N")
    {
        break;
    }
}
Console.WriteLine("Names you have entered: ");
for(int i = 0;i < counter; i++)
{
    Console.WriteLine(namesArray[i]);
}


