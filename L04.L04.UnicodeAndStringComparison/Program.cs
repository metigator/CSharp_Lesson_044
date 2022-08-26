using System;
using System.IO;

namespace Metigator44.L04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Unicode character -> code point 
            // Code point a = "\u0061";
            // graphemes: multiple char object (base, combine) : a  ̈
            // Also we have single chars that represent the graphems ä


            StreamWriter sw = new StreamWriter(@".\output.txt");
            string char1 = "\u0061"; // a
            string char2 = "\u0308"; // ̈

            sw.WriteLine(char1); // a
            sw.WriteLine(char2); // ̈


            string grapheme = "\u0061\u0308"; 
            sw.WriteLine(grapheme); // ä
        

            string singleChar = "\u00e4";
            sw.WriteLine(singleChar); // ä

            // representation are equal
            sw.WriteLine("{0} = {1} (Culture-sensitive): {2}", grapheme, singleChar,
                         String.Equals(grapheme, singleChar,
                                       StringComparison.CurrentCulture)); // true

            sw.WriteLine("{0} = {1} (Ordinal): {2}", grapheme, singleChar,
                         String.Equals(grapheme, singleChar,
                                       StringComparison.Ordinal)); // False

            sw.WriteLine("{0} = {1} (Normalized Ordinal): {2}", grapheme, singleChar,
                         String.Equals(grapheme.Normalize(),
                                       singleChar.Normalize(),
                                       StringComparison.Ordinal)); // True
            sw.Close();
        }

    }
}