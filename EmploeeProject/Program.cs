﻿// Declare variables
using System.Xml.Linq;

string? Firstname = string.Empty;
string Lastname = string.Empty;
const int retirementAge = 65;
int age = 0;
DateOnly dob = new DateOnly();
decimal salary = 0;
char gender = char.MinValue;
bool working = false;
char genderM = 'm';
char genderF = 'f';

//Promptnthe user for input
Console.WriteLine("Please, enter your Firstname");
Firstname = Console.ReadLine();

Console.WriteLine("Please, enter your Lastname");
Lastname = Console.ReadLine();


Console.WriteLine("Please, enter your date of birth (dd/mm/yyyy)");
dob = DateOnly.ParseExact(Console.ReadLine, "dd/mm/yyyy", CultureInfo.InvariantCulture);

Console.WriteLine("Please, enter your age");

age = DateTime.Now.Year - dob.Year;

Console.WriteLine("Please, enter your selary");
salary = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Please, enter your gender (m or f)");
gender = Convert.ToChar(Console.ReadLine());

Console.WriteLine("Are you working? (true or false)");
working = Convert.ToBoolean(Console.ReadLine());

//Process the data
int workingYearsRemaining1 = retirementAge - age;
var estimatedRetirementDate = DateTime.Now.AddYears(workingYearsRemaining1);

//Output the results to the user
Console.WriteLine($"Full name {Firstname} {Lastname}");
Console.WriteLine($"Age {age}");
Console.WriteLine($"Your gender is : {gender}");
Console.WriteLine($"Your salary is : {salary.ToString("C")}");
Console.WriteLine($"You are emploed : {working}");
Console.WriteLine($"Estimated Retirement year: {estimatedRetirementDate.Year}");

if (gender == 'm')
{
    if (age < 65)
    {
        int workingYearsRemaining = retirementAge - age;
        Console.WriteLine($"You will retire in {workingYearsRemaining}");
    }
    else if (age == 65)
    {
        Console.WriteLine($"You are on pension now, becouse you are {age} year old");
    }
    else
    {
        int workingYearsRemaining = age - retirementAge;
        Console.WriteLine($"You have been retired for {workingYearsRemaining} years");
    }
}
else if (gender == 'f')
{
    if (age < 55)
    {
        int workingYearsRemaining = 55 - age;
        Console.WriteLine($"You will retire in {workingYearsRemaining}");
    }
    else if (age == 55)
    {
        Console.WriteLine($"You are on pension now, becouse you are {age} year old");
    }
    else
    {
        int workingYearsRemaining = age - retirementAge;
        Console.WriteLine($"You have been retired for {workingYearsRemaining} years");
    }

}

