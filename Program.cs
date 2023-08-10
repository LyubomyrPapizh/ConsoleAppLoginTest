using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLoginTest;

class ProgramAboutUsers
{
    static void Main()
    {
        var UsersNumber = new Random().Next(2, 1000);
        var list = new List<User>();
        for (var i = 0; i < UsersNumber; i++)
        {
            var user = new User();
            user.GenerateRandomValuesForUser();
            list.Add(user); 
        }
        Console.In.ReadLine();
        
    }


}