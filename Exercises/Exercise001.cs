using System;
using System.Collections.Generic;
using Exercises.Models;

namespace Exercises
{
    public class Exercise001
    {
        public string CapitalizeWord(string word)
        {
            //check if word is " " or empty or null
            if (word == " " || String.IsNullOrEmpty(word))
                return word;
            else
            return (word.Substring(0,1).ToUpper() + word.Substring(1,word.Length-1).ToLower());
        }

        public string GenerateInitials(string firstName, string lastName)
        {
            return (firstName.Substring(0, 1) + "." + lastName.Substring(0, 1)).ToUpper();
        }

        public double AddVat(double originalPrice, double vatRate)
        {
            // Replace the exception statement below with your code!
            throw new NotImplementedException();

            // NB: Look in Exercise001Tests.cs
            //     There is a test with commented out assertions.
            //     For an extra challenge, uncomment those assertions and make that test pass too.
        }

        public string Reverse(string sentence)
        {
            // Replace the exception statement below with your code!
            throw new NotImplementedException();
        }

        public int CountLinuxUsers(List<User> users)
        {
            // Replace the exception statement below with your code!
            throw new NotImplementedException();
        }
    }
}
