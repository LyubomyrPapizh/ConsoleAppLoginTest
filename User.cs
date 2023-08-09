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

        public void GenerateRandomValues()
        {
            var rnd = new Random();
            var passwordLengh = 12;
            UserFirstName = GenerateRandomString(rnd.Next(4, 12));
            UserLastName = GenerateRandomString(rnd.Next(4, 12));
            UserPassword = GenerateRandomString(passwordLengh);
            UserBirthday = GenerateRandomDate();
            //UserBirthday -= 

                
            //Rand.Next(1923, 2005);
            //var today = DateOnly.FromDateTime(DateTime.Now);
            //var theDate = new DateOnly(rnd.Next(1923, 2005), rnd.Next(1, 12), rnd.Next(1, 28));
            //var theDate = new DateOnly(2015, 10, 21);
        }

        public IEnumerable<DateTime> GenerateRandomDate()
        {
            var rnd = new Random(Guid.NewGuid().GetHashCode());

            
                var year = rnd.Next(1, 10000);
                var month = rnd.Next(1, 13);
                var days = rnd.Next(1, DateTime.DaysInMonth(year, month) + 1);

                yield return new DateTime(year, month, days,
                    rnd.Next(0, 24), rnd.Next(0, 60), rnd.Next(0, 60), rnd.Next(0, 1000));
            
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
