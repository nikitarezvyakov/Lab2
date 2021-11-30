using System;


namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Сложность O(n)
            string stroka = Console.ReadLine();
            for (int index = stroka.Length - 1; index >= 0; index--)
            {
                Console.Write(stroka[index]);
            }
        }
    }
}
