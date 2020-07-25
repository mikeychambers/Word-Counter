using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime;
using System.Security.Cryptography.X509Certificates;
using System.Collections;
using System.Runtime.CompilerServices;

namespace ForLoopyLoops
{
    class Program
    {

        static void Main(string[] args)
        {
            ProgramLoop();
        }
        
        static void ProgramLoop()
        {
            Console.Clear();
            PrintResult(WordOcceranceInArray(StringToArray(RemovePunctuation(CreateString(GetFilePath()))), RemovePunctuation(WordToCompare())));
            GoAgain();
        }

        static void PrintResult(int i)
        {
            string x = i.ToString();
            Console.WriteLine(x);
            Console.ReadLine();
        }

        static string GetFilePath()
        {
            Console.WriteLine("Enter File Path");
            string filePath = Console.ReadLine();
            return filePath;
        }

         static string CreateString(string x)
         {
            string text = File.ReadAllText(x).ToLower();
            return text;
         }

         static string RemovePunctuation(string x)
        {
            string noPunctuation = x.Replace(".", "").Replace(",", "")
                .Replace("!", "").Replace("-", "").Replace("'", "")
                .Replace(@"""", "").Replace("?", "").Replace("(", "").Replace(")", "")
                .Replace("£", "").Replace("$", "");
            return noPunctuation;
        }
         static string[] StringToArray(string x)
         {
            string[] textToArray =  x.Split();
            return textToArray;
         }

         static string WordToCompare()
         {
            Console.WriteLine("Enter the word you want to find out the occurences of: ");
            string word = Console.ReadLine().ToLower();
            return word;
         }

         static int WordOcceranceInArray(string[]x, string y)
         {
            int count = 0;
            for (int i = 0; i < x.Length; i++)
            {
                if (y.Equals(x[i]))
                {
                    count++;
                }
            }
            return count;
         }
        
        static void GoAgain()
        {
            Console.Clear();
            Console.Write("Another Word? y/n: ");
            string goAgain = Console.ReadLine().ToLower();
            if (goAgain == "y")
            {
                Console.Clear();
                ProgramLoop();
            }

            else if (goAgain == "n")
            {
                Environment.Exit(0);
            }

            else
            {
                Console.Clear();
                GoAgain();
            }
        }
    }
}
