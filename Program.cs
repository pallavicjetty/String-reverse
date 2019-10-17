using System;

namespace stringReverse1
{
    class Program
    {
        public static void stringReverseString1()
        {
            string word = "", reverseWord = "";
            Console.WriteLine("Please input the word to be reversed");
            word = Console.ReadLine();
            //variable length holds the length of the word
            var length = word.Length - 1;
            while (length >= 0)
            {
                reverseWord = reverseWord + word[length];
                length--;
            }
            Console.WriteLine("The output is " + reverseWord);
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Program.stringReverseString1();
        }
    }
}
