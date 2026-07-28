//Console.WriteLine("Hello, World!");
//int age = 30;
//string name = "John Doe";
//Concatenation not recommended
//Console.WriteLine("my name is " + name + " and I am " + age + " years old.");
//String interpolation recommended
//Console.WriteLine($"my name is {name} and I am {age} years old.");

//#region Read From Console

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
        #region conditional statements
        int grade;
        Console.WriteLine("Enter your grade: ");

        grade = int.Parse(Console.ReadLine());
        if(grade >= 85)
        {
            Console.WriteLine("You got an A");

        }
        else if (grade >= 70)
        {
            Console.WriteLine("You got a B");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("You got a C");
        }
        else if (grade >= 50)
        {
            Console.WriteLine("You got a D");
        }
        else
        {
            Console.WriteLine("You failed");
        }
        #endregion
    }