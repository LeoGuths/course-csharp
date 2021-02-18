using System;
using System.Collections.Generic;

namespace HowManyStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> courseA = new HashSet<int>();
            HashSet<int> courseB = new HashSet<int>();
            HashSet<int> courseC = new HashSet<int>();

            Console.Write("How many students for course A? ");
            ReadStudents(courseA, int.Parse(Console.ReadLine()));

            Console.Write("How many students for course B? ");
            ReadStudents(courseB, int.Parse(Console.ReadLine()));

            Console.Write("How many students for course C? ");
            ReadStudents(courseC, int.Parse(Console.ReadLine()));

            HashSet<int> allStudents = new HashSet<int>(courseA);
            allStudents.UnionWith(courseB);
            allStudents.UnionWith(courseC);

            Console.Write("Total students: " + allStudents.Count);
        }

        private static void ReadStudents(HashSet<int> students, int howMany)
        {
            for (int i = 0; i < howMany; i++)
                students.Add(int.Parse(Console.ReadLine()));
        }
    }
}
