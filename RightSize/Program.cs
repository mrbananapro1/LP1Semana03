using System;

namespace RightSize
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach ( string word in args)
            {
                if (word.Length > 6)
                {
                    break;
                }

                if (word.Length > 3)
                {
                    Console.WriteLine(word);
                }

            }
        }
    }
}