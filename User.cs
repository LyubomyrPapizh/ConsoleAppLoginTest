using OfficeOpenXml.FormulaParsing.Excel.Functions.DateTime;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Information;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLoginTest
{
    internal class User
    {
        private string UserFirstName { get; set; }
        private string UserLastName { get; set; }
        private string UserPassword { get; set; }
        private DateOnly UserBirthday { get; set; }

        public void GenerateRandomValuesForUser()
        {
            var rnd = new Random();
            var passwordLengh = 12;
            UserFirstName = GenerateRandomString(rnd.Next(4, 12));
            UserLastName = GenerateRandomString(rnd.Next(4, 12));
            UserPassword = GenerateRandomString(passwordLengh);
            UserBirthday = DateOnly.FromDayNumber(rnd.Next(712845, 731825));
        }

        public string GenerateRandomString(int lenthForRandomString)
        {
            var randomString = "";
            var rnd = new Random();

            for (int i = 0; i < lenthForRandomString; i++)
            {
                if (i == 0)
                {
                    randomString = $"{Convert.ToChar(rnd.Next(65, 90))}";
                }
                else
                {
                    randomString += $"{Convert.ToChar(rnd.Next(97, 122))}";
                }

            }
            return randomString;
        }
    }
}
