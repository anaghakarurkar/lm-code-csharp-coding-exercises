using System;
using System.Collections.Generic;
using System.Linq;
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
                return (word.Substring(0, 1).ToUpper() + word.Substring(1, word.Length - 1).ToLower());
        }

        public string GenerateInitials(string firstName, string lastName)
        {
            return (firstName.Substring(0, 1) + "." + lastName.Substring(0, 1)).ToUpper();
        }

        public double AddVat(double originalPrice, double vatRate)
        {
            //check for invalid negative original price or varRate
            if (originalPrice < 0)
                throw new ArgumentException("Price cannot be negative. Please enter a valid price.");
            if (vatRate < 0)
                throw new ArgumentException("VAT cannot be negative. Please enter a valid VAT.");

            //Vat calculation
            double vatAmt = ((vatRate / 100) * originalPrice);

            //final value upto two decimal places
            return Math.Round(originalPrice + vatAmt, 2, MidpointRounding.AwayFromZero);

            // Extra challege test passed!
        }

        public string Reverse(string sentence)
        {
            if (sentence == " " || String.IsNullOrEmpty(sentence))
                return sentence;
            else
            {
                char[] letters = sentence.ToCharArray();
                String reversedString = "";

                for (int i = letters.Length - 1; i >= 0; i--)
                {
                    reversedString += letters[i];
                }

                return reversedString;
            }
        }

        public int CountLinuxUsers(List<User> users)
        {
            // return 0 if list is empty or null
            int userCount = 0;

            if (users == null || users.Count == 0)
                return userCount;

            //  from u in users where u.Type.Equals("Linux") =>  userCount++;

            foreach (User user in users)
            {
                if (user.Type.Equals("Linux"))
                    userCount++;
            }
            return userCount;
        }
    }
}
