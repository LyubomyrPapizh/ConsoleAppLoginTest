using OfficeOpenXml.FormulaParsing.Excel.Functions.Information;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;
using OfficeOpenXml.Style;
using System;

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
        //Console.In.ReadLine();

        for (var i = 0; i < UsersNumber; i++)
        {            
            Console.WriteLine("\n" + "User number " + i);
            Console.WriteLine(value: $"First name is   {myUsersList[i].UserFirstName}.");
            Console.WriteLine(value: $"Last name is    {myUsersList[i].UserLastName}.");
            Console.WriteLine(value: $"Password is     {myUsersList[i].UserPassword}.");
            Console.WriteLine(value: $"UserBirthday is {myUsersList[i].UserBirthday}.");
        }

        Console.In.ReadLine();

        //List<Order> SortedList = myUsersList.OrderBy(UserFirstName).ToList();
        //myUsersList.Sort(myUsersList(Delegate).UserFirstName);
             



        for (var i = 0; i < UsersNumber; i++)
        {
            Console.WriteLine("\n" + "User number " + i);
            Console.WriteLine(value: $"First name is   {myUsersList[i].UserFirstName}.");
            Console.WriteLine(value: $"Last name is    {myUsersList[i].UserLastName}.");
            Console.WriteLine(value: $"Password is     {myUsersList[i].UserPassword}.");
            Console.WriteLine(value: $"UserBirthday is {myUsersList[i].UserBirthday}.");
        }

        Console.In.ReadLine();
    }
}