using System;
using System.Text;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
           string word = "Hello World!";

          if(!Palindrome(word)) {
            Console.WriteLine("Not a palindrome");
          }
          else {
            Console.WriteLine("Is a palindrome");
          }
        }

        public static bool Palindrome(string args) {
            StringBuilder sb = new StringBuilder(); // create sb to hold the string without punctuation and whitespace

            string teststr; // create teststr to hold the string without punctuation and whitespace

            teststr = args.ToLower(); // convert the string to lowercase

            foreach (char c in teststr) // loop through the string and remove punctuation and whitespace
            {
                if (!char.IsPunctuation(c) && !char.IsWhiteSpace(c)) // if the character is not punctuation or whitespace, append it to the stringbuilder
                {
                    sb.Append(c); // append the character to the stringbuilder
                }
            }

            teststr = sb.ToString(); // convert the stringbuilder to a string
            int i = 0; // create i to hold the first index of the string
            int j = teststr.Length - 1; // create j to hold the last index of the string

            while(i <= j)
            {
                if (teststr[i] != teststr[j])   // if the characters at the indexes are not equal, return false
                {
                    Console.WriteLine("Not a palindrome"); // print that the string is not a palindrome
                    return false; // return false
                }
                i++;
                j--;
            }
            return true;
        }
    }
}