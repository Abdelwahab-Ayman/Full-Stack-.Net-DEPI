//Console.WriteLine("Hello, World!");
//int age = 30;
//string name = "John Doe";
//Concatenation not recommended
//Console.WriteLine("my name is " + name + " and I am " + age + " years old.");
//String interpolation recommended
//Console.WriteLine($"my name is {name} and I am {age} years old.");

//#region Read From Console

using System.Transactions;

internal class Program
{
    private static void Main(string[] args)
    {
        //#region Read From Console
        //int parsedAge;   //4B
        //string userName;
        //double salary; //8B

        //Console.WriteLine("Enter your age: ");

        //parsedAge = int.Parse(s: Console.ReadLine());

        //parsedAge = parsedAge;

        //Console.WriteLine("Enter your name: ");
        //userName = Console.ReadLine();

        //Console.WriteLine("Enter your salary: ");
        //salary = double.Parse(Console.ReadLine());

        //Console.WriteLine($"Your name is {userName}, you are {parsedAge} years old and your salary is {salary}.");
        //#endregion
        //#region urinary operators
        //#endregion
        //#region logical operators && , ||
        //#endregion
        //#region ternary operator
        //int x = 10;
        //int y = 20;
        //condition ? true : false
        //int z = y > x ? y : x;
        //Console.WriteLine(z);
        //#endregion
        //#region conditional statements
        //int grade;
        //Console.WriteLine("Enter your grade: ");

        //grade = int.Parse(Console.ReadLine());
        //if (grade >= 85)
        //{
        //    Console.WriteLine("You got an A");

        //}
        //else if (grade >= 70)
        //{
        //    Console.WriteLine("You got a B");
        //}
        //else if (grade >= 60)
        //{
        //    Console.WriteLine("You got a C");
        //}
        //else if (grade >= 50)
        //{
        //    Console.WriteLine("You got a D");
        //}
        //else
        //{
        //    Console.WriteLine("You failed");
        //}
        //;
        //#endregion
        //#region swich case
        //Console.WriteLine("enter month number: ");
        //int month = int.Parse(Console.ReadLine());
        //switch (month)
        //{
        //    case 1:
        //        Console.WriteLine("January");
        //        break;
        //    case 2:
        //        Console.WriteLine("February");
        //        break;
        //    case 3:
        //        Console.WriteLine("March");
        //        break;
        //    case 4:
        //        Console.WriteLine("April");
        //        break;
        //    case 5:
        //        Console.WriteLine("May");
        //        break;
        //    case 6:
        //        Console.WriteLine("June");
        //        break;
        //    case 7:
        //        Console.WriteLine("July");
        //        break;
        //    case 8:
        //        Console.WriteLine("August");
        //        break;
        //    case 9:
        //        Console.WriteLine("September");
        //        break;
        //    case 10:
        //        Console.WriteLine("October");
        //        break;
        //    case 11:
        //        Console.WriteLine("November");
        //        break;
        //    case 12:
        //        Console.WriteLine("December");
        //        break;
        //    default:
        //        Console.WriteLine("Invalid month number");
        //        break;
        //}
        //#endregion
        #region for loop
        for(int i = 1; i < 5; i++)
        {
            Console.WriteLine("these group are great .net developer");
        };
        #endregion
    }
}