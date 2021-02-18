using System;
using System.Collections.Generic;
using System.IO;

namespace DictionaryVote
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> persons = new Dictionary<string, int>();

            Console.Write("Enter file full path: ");
            try
            {
                using (StreamReader sr = File.OpenText(Console.ReadLine()))
                {
                    while(!sr.EndOfStream)
                    {
                        string[] vctor = sr.ReadLine().Split(',');
                        if (persons.ContainsKey(vctor[0])) persons[vctor[0]] += int.Parse(vctor[1]);
                        else persons.Add(vctor[0], int.Parse(vctor[1]));
                    }
                }

                foreach(var person in persons)
                    Console.WriteLine(person.Key + ": " + person.Value);
            } catch (Exception e)
            {
                throw new ArgumentException("Error! " + e.Message);
            }
        }
    }
}
