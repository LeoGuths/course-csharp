using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace ProductsLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> dictionary = new Dictionary<string, double>();

            Console.Write("Enter file full path: ");

            try
            {
                using (StreamReader sr = File.OpenText(Console.ReadLine()))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] vctor = sr.ReadLine().Split(',');
                        dictionary[vctor[0]] = double.Parse(vctor[1], CultureInfo.InvariantCulture);

                    }
                }

                var result = dictionary.Select(x => x.Value).DefaultIfEmpty(0.0).Average();
                Console.Write("Average price: " + result.ToString("F2", CultureInfo.InvariantCulture));

                Console.WriteLine("");

                dictionary.Where(x => x.Value < result).Select(x => x.Key).OrderByDescending(x => x).ToList().ForEach(x => Console.WriteLine(x));
            }
            catch (Exception e)
            {
                throw new ArgumentException("Error! " + e.Message);
            }
        }
    }
}
