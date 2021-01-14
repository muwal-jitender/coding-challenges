﻿using System;

namespace code_practicle
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "hello";
            Program.ReverseString(str);
        }

        // How to reverse a string?
        static void ReverseString(string str)
        {
            char[] charArray = str.ToCharArray();
            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                charArray[i] = str[j];
                charArray[j] = str[i];
            }
            string reversedstring = new string(charArray);
            Console.WriteLine(reversedstring);
        }
    }
}
