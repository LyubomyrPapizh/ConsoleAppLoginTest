using ConsoleAppLoginTest;
using System.Drawing;

public class UsersMaintenance
{
    public static void Main()
    {

        var ageLimit = 18;

        Console.WriteLine("""Hello, please, input your date of birth in the format DD/MM/YYYY""");
        string userInputDate = Console.ReadLine();

        var str = userInputDate;
        DateTime userBirthday;

        var isValidDate = DateTime.TryParse(str, out userBirthday);

        if (isValidDate)
            Console.WriteLine("Your Birthday is " + userBirthday);
        else
        {
            Console.WriteLine($"{str} is not a valid date string");
            Console.In.ReadLine();
        }

        var currentYear = int.Parse(DateTime.Now.Year.ToString());
        var userAge = currentYear - userBirthday.Year;

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
            Console.WriteLine("you birthday is " + userBirthday);
            Console.WriteLine("First Name: " + userFirstName);
            Console.WriteLine("Last Name: " + userLastName);
            Console.WriteLine("Password: " + userPassword + "\n");
            Console.WriteLine("Saved value for user input date is variable DateTime userBirthday. Equals: " + userBirthday + "\n");
            Console.WriteLine("Thank you for registration. Have a nice, whatever you want :)");

        }

        else
        {
            Console.WriteLine("Unfortunately we cannot register users under 18 years");
        }

        Console.In.ReadLine();
        Console.Write(User.usersArr[0, 0]);
        Console.Write("{0}\t", User.usersArr[0, 0]);
        Console.Write("{0}\t", usersArr[1, 0]);
        Console.Write("{0}\t", usersArr[2, 0]);
        Console.Write("{0}\t", usersArr[3, 0]);

    }
}