using System;
using System.Threading;

namespace BruteForce
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] arrayChars = new string[63] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s" ,"t" ,"u" , "v", "w", "x", "y", "z",
                                                    "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z",
                                                    "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", " " };


            bool match = false;
            string currentChar = "";

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Geef een wachtwoord in.");
            string pwd = Console.ReadLine();

            Console.Clear();

            char[] arrayPwd = pwd.ToCharArray();
            char[] bruteForzePwd = new char[arrayPwd.Length];

            Console.ForegroundColor = ConsoleColor.Blue;
            for (int i = 1; i <= pwd.Length; i++)
            {
                Console.Write("*");
            }
            
            Console.WriteLine(": Your password.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Cracking Password");
            Console.WriteLine("-------------------------");
            Thread.Sleep(5000);

            Console.WriteLine();

            while (!match)
            {
                for (int i = 0; i < arrayPwd.Length; i++)
                {
                    for (int c = 0; c < arrayChars.Length; c++)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        currentChar = arrayChars[c];

                        if (currentChar == Convert.ToString(arrayPwd[i]))
                        {
                            Console.WriteLine(arrayChars[c]);
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Char Found");
                            Console.ForegroundColor = ConsoleColor.Green;
                            bruteForzePwd[i] = Convert.ToChar(currentChar);

                            Thread.Sleep(2000);
                            
                        }
                    }

                    string crackedPwd = string.Concat(bruteForzePwd);

                    if (pwd == crackedPwd)
                    {
                        match = true;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine();
                        Console.WriteLine("-------------------------");
                        Console.WriteLine($"Your password was: {crackedPwd}");
                        Console.ResetColor();

                    }
                }
            }
        }
    }
}
