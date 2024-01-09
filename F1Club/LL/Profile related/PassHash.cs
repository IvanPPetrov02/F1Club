using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt;

namespace DAL
{
    public class PassHash
    {
        private static string pepper = "Bakery-Café";
        public static string GetRandomSalt()
        {
            return BCrypt.Net.BCrypt.GenerateSalt(12);
        }
        public static string HashPassword(string password)
        {
            string PassWPepper = password + pepper;
            return BCrypt.Net.BCrypt.HashPassword(PassWPepper, GetRandomSalt());
        }
        public static bool ValidatePassword(string password, string correctHash)
        {
            {
                return BCrypt.Net.BCrypt.Verify(password + pepper, correctHash);
            }
        }
    }
}
