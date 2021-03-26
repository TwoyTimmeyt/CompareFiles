using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace CompareFiles
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Info
    {
        public static string[] firstFile = File.ReadAllLines("one.txt");

        public static string[] secondFile = File.ReadAllLines("two.txt");
    }
    class Compare
    {
        public static void CompareFiles()
        {
            if (CheckElementsOne() < CheckElementsTwo())
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("+" + NewStr());
                Console.ResetColor();
                EditedOrDeleted();
            }
            else
            {
                EditedOrDeleted();
            }
        }
        private static int CheckElementsOne()
        {
            int countEl = 0;
            for (int i = 0; i < Info.firstFile.Length; i++)
                countEl += i;
            return countEl;
        }
        private static int CheckElementsTwo()
        {
            int countElTwo = 0;
            for (int i = 0; i < Info.secondFile.Length; i++)
                countElTwo += i;
            return countElTwo;
        }
        private static string NewStr()
        {
            string newStr = "";
            for (int i = 0; i < Info.secondFile.Length; i++)
            {
                newStr = Info.secondFile[1];
            }
            return newStr;
        }
        private static void EditedOrDeleted()
        {
            for (int i = 0; i < Info.firstFile.Length && i < Info.secondFile.Length; i++)
            {
                if (Info.secondFile[i] == "")
                {
                    Console.WriteLine($"{i}:" + Info.firstFile[i]);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{i}:-");
                    Console.ResetColor();
                }
                else
                {
                    IsEdited(i);
                }
            }
        }
        private static void IsEdited(int i)
        {
            if (!Info.firstFile[i].Equals(Info.secondFile[i]))
            {
                Console.WriteLine($"{i}:" + Info.firstFile[i]);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"{i}:~" + Info.secondFile[i]);
                Console.ResetColor();
            }
        }
    }
    //*
}
