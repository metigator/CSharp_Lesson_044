using System;
using System.Collections.Generic;

namespace Metigator44.L06
{
    internal class Program
    {
        public static void Main(string[] args)
        {  
            //RunCopyTo();
            // RunCompare();
            // RunStringFound();
            // RunStringFormat();
            // RunStringIsNullOrEmpty();
            // RunStringIsNullOrWhiteSpace();
            // RunStringModify();
            // RunToCase();
            // RunTrim();
            //  RunToCharacterArray();
            // RunSplit();
            RunStringJoin();
            Console.ReadKey();
        }



        static void RunCopyTo()
        {
            string s1 = "metigator";
            char[] characters = { 'f', 'u', 'l', 'l', ' ', 's', 't', 'a', 'c', 'k', ' ',
                '?', '?', '?', '?', '?', '?', '?', '?', '?'};

            Console.WriteLine(characters);

            // copies count characters from the sourceIndex position of this instance
            // to the destinationIndex position of destination character array.

            s1.CopyTo(0, characters, 11, s1.Length);
         
            Console.WriteLine(characters);
        }

        static void RunCompare()
        {
            // ascii sort order (integer, capital, small)
            // a12Bc = 12Bac

            string s1 = "metigator";
            string s2 = "Metigator";
         
            // Compares two specified String objects and returns an integer
            // that indicates their relative position in the sort order.
            Console.WriteLine(string.Compare(s1, s2, true));  // 0
            Console.WriteLine(string.Compare(s1, s2, false)); // -1
            Console.WriteLine(string.Compare(s2, s1, false)); // 1
        }

        static void RunStringFound()
        {
            // ascii sort order (integer, capital, small)
            string s1 = "metigator";

            // Returns whether a specified character occurs within this string.
            Console.WriteLine(s1.Contains("gato")); // true

            // starts with the specified character.
            Console.WriteLine(s1.StartsWith("meti")); // true

            // ends with the specified character.
            Console.WriteLine(s1.EndsWith("torx")); // false

            // Reports the zero-based index of the first occurrence
            Console.WriteLine(s1.IndexOf("tig")); //2
        }

        static void RunStringFormat()
        {
            var users = new List<dynamic>
            {
                new { Username =  "user1",  Since = new DateTime(2022, 7, 7) , Followers = 15053 },
                new { Username =  "user2",  Since = new DateTime(2021, 5, 9) , Followers = 12046 },
                new { Username =  "user3",  Since = new DateTime(2022, 11, 10) , Followers = 14027 }
            };

            // Converts the value of objects to strings based on the
            // formats specified and inserts them into another string.
            var header = String.Format("{0,-12}{1,8}{2,12}\n",
                              "Username", "Created At", "Followers");

            Console.WriteLine(header);

            foreach (var user in users)
                Console.WriteLine(String.Format("{0,-12}{1,8:yyyy}{2,12:N0}\n",
                              user.Username, user.Since, user.Followers));

        }

        static void RunStringIsNullOrEmpty()
        {
            string s1 = "metigator";
            string s2 = "";
            string s3 = "   ";
            string s4 = null;
            string s5 = String.Empty;

            // null or empty
            Console.WriteLine(String.IsNullOrEmpty(s1)); // false
          
            Console.WriteLine(String.IsNullOrEmpty(s2)); // true
          
            Console.WriteLine(String.IsNullOrEmpty(s3)); // false
         
            Console.WriteLine(String.IsNullOrEmpty(s4)); // true
        
            Console.WriteLine(String.IsNullOrEmpty(s5)); // true
        }

        static void RunStringIsNullOrWhiteSpace()
        {
            string s1 = "metigator";
            string s2 = "";
            string s3 = "   ";
            string s4 = null;
            string s5 = String.Empty;

            // null or white spaces
            Console.WriteLine(String.IsNullOrWhiteSpace(s1)); // false
           
            Console.WriteLine(String.IsNullOrWhiteSpace(s2)); // true
          
            Console.WriteLine(String.IsNullOrWhiteSpace(s3)); // true
         
            Console.WriteLine(String.IsNullOrWhiteSpace(s4)); // true
         
            Console.WriteLine(String.IsNullOrWhiteSpace(s5)); // true
        }

        static void RunStringModify()
        {
            string s1 = "metior";
            string s2 = "metizanor";
            string s3 = "metixyzgator";

            //Returns a new string in which a specified string is inserted at a
            //specified index position in this instance.
            s1 = s1.Insert(4, "gat");
            Console.WriteLine(s1); // metigator

            // all occurrences the current string are replaced with
            // another specified Unicode character or String.
            s2 = s2.Replace("zan", "gat");
            Console.WriteLine(s2); // metigator

            //Returns a new string in which a specified number of characters
            //from the current string are deleted.
            s3 = s3.Remove(4, 3);
            Console.WriteLine(s3); // metigator
        }

        static void RunToCase()
        {
            string s1 = "Metigator";
         
            // Returns a copy of this string converted to uppercase 
            // might produce culture specific output,
            // use it when user input string in their own language
            Console.WriteLine(s1.ToUpper());

            // Returns a copy of this string converted to lowercase.
            // might produce culture specific output,
            // use it when user input string in their own language
            Console.WriteLine(s1.ToLower());

            // Returns a copy of this string converted to lowercase.
            // use for non language specific data
            Console.WriteLine(s1.ToLowerInvariant());

            // Returns a copy of this string converted to uppercase.
            // use for non language specific data
            Console.WriteLine(s1.ToUpperInvariant());
        }

        static void RunTrim()
        {
            string s1 = "   Metigator   ";
            string s2 = "...Metigator....";

            //Removes all leading and trailing occurrences
            Console.WriteLine("Trim(), Trim(char)");
            Console.WriteLine(s1.Trim());    // "Metigator"
            Console.WriteLine(s2.Trim('.')); // "Metigator"

            //Removes all leading  occurrences
            Console.WriteLine("TrimStart(), TrimStart(char)");
            Console.WriteLine(s1.TrimStart()); // "Metigator   "
            Console.WriteLine(s2.TrimStart('.'));// "Metigator...."

            //Removes all trailing  occurrences
            Console.WriteLine("TrimEnd(), TrimEnd(char)");
            Console.WriteLine(s1.TrimEnd());//  "   Metigator"
            Console.WriteLine(s2.TrimEnd('.')); // "...Metigator"
        }

        static void RunToCharacterArray()
        {
            string s1 = "metigator";
            char[] characters;
         
            //Copies the characters in this instance to a Unicode character array.
            characters = s1.ToCharArray();
        
            foreach (char ch in characters)
                Console.Write($" {ch}");
        }

        static void RunSplit()
        {
            string s1 = "This is metigator channel";
           
            // Returns a string array that contains the substrings
            // in this instance that are delimited by elements of
            // a specified string or Unicode character array.
            string[] words = s1.Split(" ");
         
            foreach (var word in words)
                Console.WriteLine(word);
        }

        static void RunStringJoin()
        {
            string[] values = { "Los Angeles", "1st Jan 1940", "15M" };
          
            //Concatenates the elements of a specified array or the members
            //of a collection, using the specified separator between each
            //element or member.
            string commaSeparated = string.Join(',', values);
        
            Console.WriteLine(commaSeparated); // Los Angeles,1st Jan 1940,15M
        }


    }
}