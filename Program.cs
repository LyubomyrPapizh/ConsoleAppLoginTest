using Microsoft.Win32;
using System;
using System.ComponentModel.Design;
using System.Reflection;

public class Example
{
    private static int userYear;
    private static int currentYear;
    private static int ageLimit = 18;
    public static void Main()
    {
        Console.WriteLine("Hello, please, input your year of birth");
        int userYear = Int32.Parse(Console.ReadLine()); 
        int currentYear = Int32.Parse(DateTime.Now.Year.ToString());
        int userAge = currentYear - userYear;

        if (userAge >= ageLimit)

        {
            Console.WriteLine("Please, input your first name");
            string userFirstName = Console.ReadLine();

            Console.WriteLine("Please, input your last name");
            string userLastName = Console.ReadLine();

            Console.WriteLine("Please, input your password");
            string userPassword = Console.ReadLine();

            Console.WriteLine("Summary");
            Console.WriteLine("you have " + userAge + " years");
            Console.WriteLine("First Name: " + userFirstName);
            Console.WriteLine("Last Name: " + userLastName);
            Console.WriteLine("Password: " + userPassword);
            Console.WriteLine("Thank you for registration. Have a nice, whatever you want :)");

        }

        else
        {
            Console.WriteLine("unfortunately we cannot register users under 18 years");
        }

        Console.In.ReadLine();
    }
}