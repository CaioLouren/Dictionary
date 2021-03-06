using System;
using System.IO;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> NumeroDeVotos = new Dictionary<string, int>();

            Console.WriteLine("Enter file full path: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string name = line[0];
                        int number = int.Parse(line[1]);

                        if (!NumeroDeVotos.ContainsKey(name))
                        {
                            NumeroDeVotos.Add(name, number);
                        }
                        else
                        {
                            NumeroDeVotos[name] += number;
                        }
                       
                    }
                    foreach (KeyValuePair<string, int> item in NumeroDeVotos)
                    {
                        Console.WriteLine(item.Key + ": " + item.Value);
                    }

                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}