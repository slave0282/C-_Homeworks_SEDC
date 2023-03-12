//Make a console application called SumOfEven.
//Inside it create an array of 6 integers.
//Get numbers from the input, find and print the sum of the even numbers from the array:

int[] arrayOfInts = new int[6];
Console.WriteLine("Enter six numbers: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
int secondNum = Convert.ToInt32(Console.ReadLine());
int thirdNum = Convert.ToInt32(Console.ReadLine());
int fourthNum = Convert.ToInt32(Console.ReadLine());
int fifthNum = Convert.ToInt32(Console.ReadLine());
int sixthNum = Convert.ToInt32(Console.ReadLine());
arrayOfInts[0] = firstNum;
arrayOfInts[1] = secondNum;
arrayOfInts[2] = thirdNum;
arrayOfInts[3] = fourthNum;
arrayOfInts[4] = fifthNum;
arrayOfInts[5] = sixthNum;
int sumOfEven = 0;
for (int i = 0; i < arrayOfInts.Length; i++)
{
    if (arrayOfInts[i] % 2 == 0)
    {
        sumOfEven += arrayOfInts[i];
    }
}
Console.WriteLine("The sum of the even numbers given in the array is: " + sumOfEven);
