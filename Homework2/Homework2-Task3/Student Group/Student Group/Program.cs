//Make a new console application called StudentGroup
//Make 2 arrays called studentsG1 and studentsG2 and fill them with 5 student names (strings).
//Get a number from the console between 1 and 2 and print the students from that group in the console

string[] studentsG1 = new string[]
{
    "Luka","Matej","Damjan","Robert","Kiko"
};
string[] studentsG2 = new string[]
{
    "Slave","Mario","Ognen","Ema","Ilija"
};
Console.WriteLine("Enter 1 if you want to see the students of G1, otherwise enter 2 for the students of G2");
string userChoosing = Console.ReadLine();
Console.WriteLine(" ");
switch (userChoosing)
{
    case "1":
        {
            for(int i = 0; i < studentsG1.Length; i++)
            {
                Console.WriteLine(studentsG1[i]);
            }
            break;
        }
        case "2": { for(int i = 0;i < studentsG2.Length; i++){
                Console.WriteLine(studentsG2[i]);
            }
        break;
}
        default:
        {
            Console.WriteLine("You have entered an invalid option!" +
                "Please try again!");
        }
        break;
               
}