﻿using System;
using System.Collections.Generic;

namespace _02._Phonebook_Upgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');
            SortedDictionary<string, string> dict = new SortedDictionary<string, string>();

            while (line[0] != "END")
            {
                if (line[0] == "A")
                {
                    dict[line[1]] = line[2];
                }
                else if (line[0] == "S")
                {
                    if (dict.ContainsKey(line[1]))
                    {
                        Console.WriteLine(line[1] + " -> " + dict[line[1]]);
                    }
                    else
                    {
                        Console.WriteLine("Contact {0} does not exist.", line[1]);
                    }
                }
                else if (line[0] == "ListAll")
                {
                    foreach (var entry in dict)
                    {
                        Console.WriteLine(entry.Key + " -> " + entry.Value);
                    }
                }

                    line = Console.ReadLine().Split(' ');
            }
        }
    }
}
