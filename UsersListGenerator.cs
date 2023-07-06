using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLoginTest
{
    public class User
    {
        //internal static object? usersArr;

        static void Main(string[] args, int usersNumber)
        {
            //int[] myArr = { 4, 5, -183, 12, 34, 0, 2, -13 };

            //Console.WriteLine("Исходный массив чисел: ");
            //foreach (int x in myArr)
            //    Console.Write("\t{0}", x);

            //// Реализуем сортировку массива
            //Console.WriteLine("\n\nОтсортированный массив:");
            //Array.Sort(myArr);
            //foreach (int x in myArr)
            //    Console.Write("\t{0}", x);

            //// Организуем поиск числа 12
            //Console.WriteLine("\n\nПоиск числа:");
            //int search = Array.BinarySearch(myArr, 12);
            //Console.WriteLine("Число 12 находится на {0} позиции", search + 1);

            //Console.ReadLine();

            string[,] usersArr = new string[3, (usersNumber - 1) ];

            Random ran = new Random();

            //foreach (int i in usersArr.Length)
                for (int i = 1; i < usersNumber; i++)
                {
                var symbolsLenthForUserSettings = 8;
                string randomSymbolsSet = SymbolsRowGenerator.GetRandomSymbolsSet(symbolsLenthForUserSettings);
                usersArr[0, i] = randomSymbolsSet; //FirstName
                randomSymbolsSet = SymbolsRowGenerator.GetRandomSymbolsSet(symbolsLenthForUserSettings);
                usersArr[1, i] = randomSymbolsSet; //LastName
                randomSymbolsSet = SymbolsRowGenerator.GetRandomSymbolsSet(symbolsLenthForUserSettings);
                usersArr[2, i] = randomSymbolsSet; //Password
                
                usersArr[3, i] = randomSymbolsSet; //Birthday
                Console.Write("{0}\t", usersArr[0, i]);
                Console.Write("{0}\t", usersArr[1, i]);
                Console.Write("{0}\t", usersArr[2, i]);
                Console.Write("{0}\t", usersArr[3, i]);

                Console.WriteLine();
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
