// Declare variables
using System.Xml.Linq;

string? Firstname = string.Empty;
string Lastname = string.Empty;
int retirementAge = 65;
int age = 0;
decimal salary = 0;
char gender = char.MaxValue;
bool working = false;

//Promptnthe user for input
Console.WriteLine("Please, enter your Firstname");
Firstname = Console.ReadLine();

Console.WriteLine("Please, enter your Lastname");
Lastname = Console.ReadLine();

Console.WriteLine("Please, enter yor age");
age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please, enter your selary");
salary = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Please, enter your gender (m or f)");
gender = Convert.ToChar(Console.ReadLine());

Console.WriteLine("Are you working? (true or false)");
working = Convert.ToBoolean(Console.ReadLine());

//Process the data
int workingYearsRemaining = retirementAge - age;

//Output the results to the user
Console.WriteLine("Full name" + Firstname + Lastname);
Console.WriteLine($"Age {age}");
Console.WriteLine($"Your gender is : {gender}");
Console.WriteLine($"Your salary is : {salary}");
Console.WriteLine($"You are emploed : {working}");
Console.WriteLine($"Number of working years remaining : {workingYearsRemaining}");


