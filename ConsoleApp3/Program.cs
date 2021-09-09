using System;
using System.Linq;

namespace PasswordChecker
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Let’s start by defining all of the standards for a password.
            int minLength = 8;

            //string lowercase = "qwertyuiopasdfghjklzxcvbnm";
            //string uppercase = "QWERTYUIOPASDFGHJKLZXCVBNM";
            //string digits = "0123456789";
            //string specialChars = "!@#$%^&*()_+-=[]|{};:<>?,.";

            //Ask the user to enter a password and capture their input in a variable.
            Console.WriteLine("Enter a password.");
            string password = Console.ReadLine();

            //Make boolean so we can use in if statements later on for validation 
            bool containsAtLeastOneUppercase = password.Any(char.IsUpper);
            bool containsAtLeastOneLowercase = password.Any(char.IsLower);
            bool containsAtLeastOneSpecialChar = password.Any(ch => !Char.IsLetterOrDigit(ch));
            bool containsAtLeastOneDigit = password.Any(char.IsDigit);

            //Define a variable score to hold their score and set it to 0.
            int score = 0;

            //If the password is greater than or equal to the minimum length, add a point to the score.
            if (password.Length >= minLength)
            {
                score++;
                Console.WriteLine("Minimum Length test passed.");
            }
            else
            {
                Console.WriteLine("Minimum Length test failed.");
            }

            //If the password contains uppercase letters, add a point.
            //if (Tools.Contains(password, uppercase))
            if (containsAtLeastOneUppercase)
            {
                score++;
                Console.WriteLine("Uppercase test passed.");
            }
            else
            {
                Console.WriteLine("Uppercase test failed.");
            }

            //If the password contains lowercase letters, add a point.
            //if (Tools.Contains(password, lowercase))
            if (containsAtLeastOneLowercase)
            {
                score++;
                Console.WriteLine("Lowercase test passed.");
            }
            else
            {
                Console.WriteLine("Lowercase test failed.");
            }

            //If the password contains digits, add a point.
            //if (Tools.Contains(password, digits))
            if (containsAtLeastOneDigit)
            {
                score++;
                Console.WriteLine("Digits test passed.");
            }
            else
            {
                Console.WriteLine("Digits test failed.");
            }

            //If the password contains special characters, add a point.
            //if (Tools.Contains(password, specialChars))
            if (containsAtLeastOneSpecialChar)
            {
                score++;
                Console.WriteLine("Special Characters test passed.");
            }
            else
            {
                Console.WriteLine("Special Characters test failed.");
            }

            //Print the score to the console
            Console.WriteLine($"Final Score: {score}");

            switch (score)
            {
                case 5: case 4: Console.WriteLine("Password strength is extremely strong."); break;
                case 3: Console.WriteLine("Password strength is strong."); break;
                case 2: Console.WriteLine("Password strength is medium."); break;
                case 1: Console.WriteLine("Password strength is weak."); break;
                case 0: Console.WriteLine("Password strength is crap."); break;
                default: Console.WriteLine("ERROR!"); break;
            }
        }
    }
}
