using System;
using System.Runtime.InteropServices;

namespace Metigator44.L03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //UsingQuotedStringLiterals();

            //UsingStringConstructor();

            //UsingRepeatingCharacter();

            //UsingPointerToSignedByte();

            //UsingAPointerToCharacterArray();

            //UsingConcatenation();

            //UsingCallingMethodThatReturnsString();

            //UsingFormattedString();

            //UsingVerbatimWithStringInterpolation();

            //UsingRawString();

            Console.ReadKey();
        }



        private static void UsingQuotedStringLiterals()
        {
            // Suited for strings that fit on a single line

            string str = "Metigator";
            Console.WriteLine(str);
        }

        private static void UsingStringConstructor()
        {
            // [2] using String Constructor (array of characters)
            char[] letters = { 'M', 'e', 't', 'i', 'g', 'a', 't', 'o', 'r' };
            string str = new string(letters);
            Console.WriteLine(str);
        }

        private static void UsingRepeatingCharacter()
        {
            // [3] // Create a string that consists of a character repeated 8 times.
            string str = new string('M', 8);
            Console.WriteLine(str);
        }

        private static void UsingPointerToSignedByte()
        {
            // [4] Create a string from a pointer to a signed byte array.
            //                'M'   'e'   't'   'i'   'g'   'a',  't',  'o'   'r'
            sbyte[] bytes = { 0x4D, 0x65, 0x74, 0x69, 0x67, 0x61, 0x74, 0x6F, 0x72 };
            string str = null;
            // safe context (use pointer, allocation memory block,
            // call method using function pointer
            unsafe
            {
                // Pin the buffer to a fixed location in memory.
                fixed (sbyte* ptr = bytes)
                {
                    str = new string(ptr);
                    Console.WriteLine(str);

                }
            }
        }

        private static void UsingAPointerToCharacterArray()
        {
            // [5] Create a string from a pointer to a character array.
            char[] letters = { 'M', 'e', 't', 'i', 'g', 'a', 't', 'o', 'r' };

            string str = null;
            unsafe
            {
                fixed (char* pchars = letters)
                {
                    // Create a string from a pointer to a character array.
                    str = new string(pchars);
                    Console.WriteLine(str);
                }
            }
        }

        private static void UsingConcatenation()
        {
            // [5] Using concatenation
            string str1 = "Meti" + "gator";
            string str2 = $"{"Meti"}{"gator"}"; // string interpolation

            Console.WriteLine($"str1 = {str1}");
            Console.WriteLine($"str2 = {str2}");
        }

        private static void UsingCallingMethodThatReturnsString()
        {
           
            string sentence = "I Love Metigator channel.";

            int startPos = sentence.IndexOf("Metigator"); // 7

            string str = sentence.Substring(startPos, 9); // string from 7, 

            Console.WriteLine(str);

        }

        private static void UsingFormattedString()
        {
            // using formatted string will convert any object to string representation
            string customer = "Issam A";
            DateTime shippingDate = DateTime.Now; // yyyy-MM-dd hh:mm
            DateTime expectedDelivery = shippingDate.AddDays(7); // yyyy-MM-dd hh:mm
            decimal shippingCost = 29.99m;

            string str = String.Format(
                "\nDear {0}.," +
                "\n\nAt {1:t} on {1:D}, the order is on its way to you" +
                "\nIt's expected to be delivered at {2:t} on {2:D}, the order is on its way to you" +
                "\nShipping cost {3:c}."+
                "\n\t\t\tThanks for shopping with us!",
                   
                customer, shippingDate, expectedDelivery, shippingCost);
               //   0           1              2                3
            Console.WriteLine(str);
        }

        private static void UsingVerbatimWithStringInterpolation()
        {
            string customer = "Issam A";
            DateTime shippingDate = DateTime.Now;
            DateTime expectedDelivery = shippingDate.AddDays(7);
            decimal shippingCost = 29.99m;

            string str = $@"Dear {customer},

At {shippingDate:t} on {shippingDate:D}, the order is on its way to you
It's expected to be delivered at {expectedDelivery:t} on {expectedDelivery:D}, the order is on its way to you
Shipping cost {shippingCost:c}.
                        Thanks for shopping with us!";
            Console.WriteLine(str);
        }
         
        private static void UsingRawString()
        {
            // Raw string starting from C# 11.0 
            string str = """
                    <nav class="box">
                        <ul>
                            <a href="javascript:void(0)">"Home"</a>
                        <li>
                        <ul>
                            <a href="javascript:void(0)">About us</a>
                        <li>
                    </nav>
                """;

            string str2 = """ this is a single line raw string""";
            Console.WriteLine(str);
            Console.WriteLine(str2);

        }
    }
}