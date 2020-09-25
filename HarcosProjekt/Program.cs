using System;
using System.Collections.Generic;

namespace HarcosProjekt
{
    class Program
    {
        static List<Harcos> tagok;
        static void Main(string[] args)
        {
            tagok = new List<Harcos>() { new Harcos("ZOLTÁÁN", 2), new Harcos("OSzablcs", 1), new Harcos("Zsombor", 3) };
        }
    }
}
