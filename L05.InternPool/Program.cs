using System;

namespace Metigator44.L05
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // RunStringLiteralVsObject();
            // RunStringLiteralKey();
            // RunStringLiteralWithStringObjectComparison();
             RunStringIntern();

            Console.ReadKey();

        }

        public static void RunStringLiteralVsObject()
        {
            string s1 = "metigator"; // string literal
            string s2 = new string ("metigator"); // string object


            Console.WriteLine(s1 == s2);                   // true same content (string override equality value based)
            Console.WriteLine(s1.Equals(s2));              // true same content

            Console.WriteLine((Object)s1 == (Object)s2);   // false two different reference
            Console.WriteLine(ReferenceEquals(s1, s2));    // false two different reference

        }

        public static void RunStringLiteralKey()
        {
            string s1 = "metigator"; // string literal
            string s2 = "aspnet"; // string literal 
            string s3 = "meti" + "gator"; // string literal

             

            Console.WriteLine(s1 == s2);                   // false  different content
            Console.WriteLine(ReferenceEquals(s1, s2));    // false two different reference


            Console.WriteLine(s1 == s3);   // true same content
            Console.WriteLine(ReferenceEquals(s1, s3));   // true same reference
        }

        public static void RunStringLiteralWithStringObjectComparison()
        {
            string s1 = "metigator"; // string literal
           //string s11 = "metigator";
            string s2 = new string("metigator");                  // string object

            Console.WriteLine(s1 == s2);                   // true, same content

            Console.WriteLine(ReferenceEquals(s1, s2));   // false different reference

        }

        public static void RunStringIntern()
        {
            string s1 = "metigator";                       // string literal

            string s2 = new string("metigator");   // string object

            string s3 = String.Intern(s2);                  // string literal

            Console.WriteLine(s1 == s2);                   // true, same content 
            Console.WriteLine(ReferenceEquals(s1, s2));   // false different reference

            Console.WriteLine(s2 == s3);                   // true, same content 
            Console.WriteLine(ReferenceEquals(s2, s3));   // false different reference

            Console.WriteLine(s1 == s3);                   // true, same content 
            Console.WriteLine(ReferenceEquals(s1, s3));   // true, same reference


            string str = "xyz";

            Console.WriteLine(str);

        }
    }
}