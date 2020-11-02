using System;
using System.Collections.Generic;

namespace VisitorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var entries = new List<IEntry> {
                new EntryA(),
                new EntryB(),
                new EntryC()
                };

            var entryInformationConsole = new EntryInformationConsole();

            foreach (var entry in entries)
            {
                entryInformationConsole.Write(entry);
            }

            Console.ReadLine();
        }
    }
}
