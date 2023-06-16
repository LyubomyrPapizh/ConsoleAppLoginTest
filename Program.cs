using Microsoft.Win32;
using System;
using System.ComponentModel.Design;
using System.Globalization;
using System.Reflection;

public class Example
{
    public static void Main()
    {
        var ageLimit = 18;
        Console.WriteLine("""Hello, please, input your date of birth in the format DD/MM/YYYY""");
        string userInputDate = Console.ReadLine();
        DateTime userInputDateParsed = DateTime.Parse(userInputDate, CultureInfo.CreateSpecificCulture("en-GB"));
        var currentYear = int.Parse(DateTime.Now.Year.ToString());
        var userAge = currentYear - userInputDateParsed.Year;

        if (userAge >= ageLimit)
        {
            Console.WriteLine("Please, input your first name");
            string userFirstName = Console.ReadLine();

            Console.WriteLine("Please, input your last name");
            string userLastName = Console.ReadLine();

            Console.WriteLine("Please, input your password");
            string userPassword = Console.ReadLine();

            Console.WriteLine("\n" + "Summary" + "\n");
            Console.WriteLine("you have " + userAge + " years");
            Console.WriteLine("you birthday is " + userInputDateParsed);
            Console.WriteLine("First Name: " + userFirstName);
            Console.WriteLine("Last Name: " + userLastName);
            Console.WriteLine("Password: " + userPassword + "\n");
            Console.WriteLine("Saved value for user input date is variable userInputDateParsed. Equals: " + userInputDateParsed + "\n");
            Console.WriteLine("Thank you for registration. Have a nice, whatever you want :)");

        }

        else
        {
            Console.WriteLine("Unfortunately we cannot register users under 18 years");
        }

        Console.In.ReadLine();
    }
}