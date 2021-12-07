using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = InputData();

            str = ReverseString(str);

            OutputData(str);
        }

        static string ReverseString(string str)
        {
            string result = "";  
            for (int index = str.Length - 1; index >= 0; index--)
            {
                result += str[index];
            }
            return result;
        }

        static void OutputData(string str)
        {
            Console.WriteLine(str);
        }

        static string InputData()
        {
            return Console.ReadLine();
        }
    }
}