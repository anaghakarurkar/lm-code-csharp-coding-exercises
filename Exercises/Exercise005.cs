using System;
namespace Exercises
{
    public class Exercise005
    {
        public bool IsPangram(string input)
        {
            //alphabet count
            int count = 0;
            string alphabets = "abcdefghijklmnopqrstuvwxyz";
            input = input.ToLower();
          
            //check if every input string alphabet is in alphabets list
            // if count is 26 return true
          for(int i = 0; i< input.Length; i++)
            {
                if (alphabets.Contains(input[i]))
                {
                        count++;
                        input = input.Replace(input[i], ' ');
                        continue;

                }
                
            }
            return count == 26;

        }
    }
}
