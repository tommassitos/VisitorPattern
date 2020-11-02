using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern
{
    public class EntryInformationConsole : IEntryVisitor
    {
        public void Write(IEntry entry) => entry.Accept(this);

        public void Visit(EntryA entry) => ToConsole(entry.GetType().ToString());
        public void Visit(EntryB entry) => ToConsole(entry.GetType().ToString());
        public void Visit(EntryC entry) => ToConsole(entry.GetType().ToString());

        void ToConsole(string name) => Console.WriteLine($"Visit: {name}");
    }
}