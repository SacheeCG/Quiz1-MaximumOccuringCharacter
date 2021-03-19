using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            var stringInput = string.Empty;
            Console.Write("Find maximum occurring character in a string :\n");
            Console.Write("--------------------------------------------------\n");
            Console.Write("Input the string : ");
            stringInput = Console.ReadLine();
            var maxOccuringChar = GetMaxOccuringChar(stringInput);
            Console.WriteLine("Maximum Occurring letter : " + maxOccuringChar);
            Console.ReadLine();
        }

        private static char GetMaxOccuringChar(String str)
        {
            int ASCII_SIZE = 256;
            int[] count = new int[ASCII_SIZE];
            int len = str.Length;
            for (int i = 0; i < len; i++)
                count[str[i]]++;

            int max = -1;
            char result = ' ';
            for (int i = 0; i < len; i++)
            {
                if (max < count[str[i]])
                {
                    max = count[str[i]];
                    result = str[i];
                }
            }

            return result;
        }
    }
    
}
