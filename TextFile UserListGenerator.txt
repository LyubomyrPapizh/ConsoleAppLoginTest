using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ConsoleAppLoginTest;
using System.Drawing;

namespace ConsoleAppLoginTest
{
    public class User
    {
        //internal static object? usersArr;

        static void Main(string[] args, int usersNumber)
        {
            string[,] usersArr = new string[3, (usersNumber - 1)];
            Random ran = new Random();

            for (int i = 1; i < usersNumber; i++)
            {
                var symbolsLenthForUserSettings = 8;
                string randomSymbolsSet = SymbolsRowGenerator.GetRandomSymbolsSet(symbolsLenthForUserSettings);
                usersArr[0, i] = randomSymbolsSet; //FirstName
                randomSymbolsSet = SymbolsRowGenerator.GetRandomSymbolsSet(symbolsLenthForUserSettings);
                usersArr[1, i] = randomSymbolsSet; //LastName
                randomSymbolsSet = SymbolsRowGenerator.GetRandomSymbolsSet(symbolsLenthForUserSettings);
                usersArr[2, i] = randomSymbolsSet; //Password

            }
        }
        class RandomDateTime
        {
            DateTime start;
            Random gen;
            int range;

            public RandomDateTime()
            {
                start = new DateTime(1950, 1, 1);
                gen = new Random();
                range = (DateTime.Today - start).Days;
            }
            public DateTime Next()
            {
                return start.AddDays(gen.Next(range)).AddHours(gen.Next(0, 24)).AddMinutes(gen.Next(0, 60)).AddSeconds(gen.Next(0, 60));
            }
        }

        Console.Write("{0}\t", usersArr[0, 0]);
        Console.Write("{0}\t", usersArr[1, 0]);
        Console.Write("{0}\t", usersArr[2, 0]);
        Console.Write("{0}\t", usersArr[3, 0]);

        // sorting start                               
        Array.Sort(usersArr, 3, 0);
        Console.WriteLine("After sorting:");
        PrintKeysAndValues(usersArr);
        // sorting end
    }

    public static void PrintKeysAndValues(string[] usersArr)
    {
        for (int i = 0; i < usersArr.Length; i++)
        {
            Console.Write("{0}\t", usersArr[0, i]);
            Console.Write("{0}\t", usersArr[1, i]);
            Console.Write("{0}\t", usersArr[2, i]);
            Console.Write("{0}\t", usersArr[3, i]);
        }
        Console.WriteLine();
    }
    public void userSearchInArray()
    {
        Console.WriteLine("""Please, input User Name for Search""");
        string userNameForSearch = Console.ReadLine();

        for (int i = 0; i < usersArr.Length; i++)
        {
            if (usersArr[0, i] == userNameForSearch)
            {
                Console.WriteLine(string.Format("User Name '{0}' '{1}' is in the users collection", userArr[0, i], userArr[1, i]);
            }

        }
    }




    public class SymbolsRowGenerator
    {
        public static string GetRandomSymbolsSet(int length)
        {
            //const string chars = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string charsCapital = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string charsLowercase = "abcdefghijklmnopqrstuvwxyz";

            StringBuilder sb = new StringBuilder();
            Random rnd = new Random();

            var index = rnd.Next(charsCapital.Length);
            sb.Append(charsCapital[index]);

            for (var i = 1; i < length; i++)
            {
                index = rnd.Next(charsLowercase.Length);
                sb.Append(charsLowercase[index]);
            }

            return sb.ToString();
        }

    }
}
