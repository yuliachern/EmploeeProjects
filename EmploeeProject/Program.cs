// Declare variables
using System.Xml.Linq;

string Firstname = string.Empty;
string Lastname = string.Empty;
int retirementAge = 65;
int age = 0;

//Promptnthe user for input
Console.WriteLine("Please, enter your Firstname");
Firstname = Console.ReadLine();

Console.WriteLine("Please, enter your Lastname");
Lastname = Console.ReadLine();

Console.WriteLine("Please, enter yor age");
age = Convert.ToInt32(Console.ReadLine());

//Process the data
int workingYearsRemaining = retirementAge - age;

//Output the results to the user
Console.WriteLine("Full name" + Firstname + Lastname);
Console.WriteLine($"Age {age}");
Console.WriteLine($"Working years remaining {workingYearsRemaining}");

