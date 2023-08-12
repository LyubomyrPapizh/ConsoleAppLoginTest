namespace ConsoleAppLoginTest;

class ProgramAboutUsers
{
    static void Main()
    {
        var UsersNumber = new Random().Next(3, 5);
        var myUsersList = new List<UsersSet>();
        for (var i = 0; i < UsersNumber; i++)
        {
            var user = new UsersSet();
            user.GenerateRandomValuesForUser();
            myUsersList.Add(user);
        }
        Console.WriteLine("Unsorted users list");
        for (var i = 0; i < UsersNumber; i++)
        {
            Console.WriteLine("\n" + "User number " + i);
            Console.WriteLine(value: $"First name is   {myUsersList[i].UserFirstName}.");
            Console.WriteLine(value: $"Last name is    {myUsersList[i].UserLastName}.");
            Console.WriteLine(value: $"Password is     {myUsersList[i].UserPassword}.");
            Console.WriteLine(value: $"UserBirthday is {myUsersList[i].UserBirthday}.");
        }

        Console.WriteLine("\n" + "Hello, please, input (1) to see userslist sorted by Name" +
                          "\n" + "Hello, please, input (2) to see userslist sorted by Birthday");
        var sortBy = int.Parse(Console.ReadLine().ToString());
        if (sortBy == 1)
        {
            myUsersList.Sort((x, y) => x.UserFirstName.CompareTo(y.UserFirstName));

            //не знаю як передати в попередню стрічку замість UserFirstName текстовае значення нової змінної
            //яка би приймала різні значення, в залежності від вводу користувача

            Console.WriteLine("\n" + "Users list sorted by User Name");
        }
        else if (sortBy == 2)
        {
            myUsersList.Sort((x, y) => x.UserBirthday.CompareTo(y.UserBirthday));
            Console.WriteLine("\n" + "Users list sorted by User Birthday");
        }
        else
        {
            myUsersList.Sort((x, y) => x.UserFirstName.CompareTo(y.UserFirstName));
            Console.WriteLine("\n" + "Incorrect Input" + "\n" + "\n" + "Show you Users list " +
                "sorted by User First Name");
        }

        for (var i = 0; i < UsersNumber; i++)
        {
            Console.WriteLine("\n" + "User number " + i);
            Console.WriteLine(value: $"First name is   {myUsersList[i].UserFirstName}");
            Console.WriteLine(value: $"Last name is    {myUsersList[i].UserLastName}");
            Console.WriteLine(value: $"Password is     {myUsersList[i].UserPassword}");
            Console.WriteLine(value: $"UserBirthday is {myUsersList[i].UserBirthday}");
        }

        Console.WriteLine("\n" + "Input User First Name for Search");
        string userNameForSearch = Console.ReadLine();
        for (var i = 0; i < UsersNumber; i++)
        {
            if (userNameForSearch == myUsersList[i].UserFirstName)
            {
                Console.WriteLine("\n" + "Search result" + "\n" + "User number " + i);
                Console.WriteLine(value: $"First name is   {myUsersList[i].UserFirstName}");
                Console.WriteLine(value: $"Last name is    {myUsersList[i].UserLastName}");
                Console.WriteLine(value: $"Password is     {myUsersList[i].UserPassword}");
                Console.WriteLine(value: $"UserBirthday is {myUsersList[i].UserBirthday}");
            }
        }
        Console.WriteLine("\n" + "If you see the search results, you are presented with all " +
    "users with the First Name <" + userNameForSearch + "> in the list" + "\n" +
    "Else, unfortunately, there is no user with such First Name");
        Console.In.ReadLine();
    }
}