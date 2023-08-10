using OfficeOpenXml.Style;

namespace ConsoleAppLoginTest;

class ProgramAboutUsers
{
    static void Main()
    {
        var UsersNumber = new Random().Next(2, 10);
        var myUsersList = new List<UsersSet>();
        for (var i = 0; i < UsersNumber; i++)
        {
            var user = new UsersSet();
            user.GenerateRandomValuesForUser();
            myUsersList.Add(user);
        }
        Console.In.ReadLine();

        Console.WriteLine($"My name is {myUsersList[0]}.");
        Console.WriteLine($"My name is {myUsersList[1]}.");
        Console.WriteLine($"My name is {myUsersList[2]}.");

        Console.In.ReadLine();
                
        myUsersList.Sort();

        foreach (var item in myUsersList) Console.WriteLine(myUsersList);

        Console.In.ReadLine();
    }
}