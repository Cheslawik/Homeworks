using lesson12.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson12.MyClasses
{
    internal static class Authentification
    {
        public static void Validate(string login, string password, string confirmPassword)
        {
            if (login.Length < 5 || 
                login.Length > 20 || 
                login.Contains(" "))
            {
                throw new WrongLoginException("Login must be between 5 and 20 characters long and don't include empty spaces.");
            }

            bool hasDigit = false;
            foreach (char c in password)
            {
                if (char.IsDigit(c))
                {
                    hasDigit = true;
                    break;
                }
            }
            if (password.Length < 8 || 
                password.Length > 20 || 
                !hasDigit || 
                password.Contains(" "))
            {
                throw new WrongPasswordException("Password must be between 8 and 20 characters long and include one number, and exclude empty spaces.");
            }

            if (password != confirmPassword)
            {
                throw new WrongPasswordConfirmationException("Password and confirmation password do not match.");
            }
        }
    }
}
