using System;
using System.Collections.Generic;
using System.IO;

namespace HarcosProjekt
{
    class Program
    {
        static List<Harcos> tagok;
        static void Beolvas(string file)
        {
            StreamReader sr = new StreamReader(file);
            while (!sr.EndOfStream)
            {
                string[] sor = sr.ReadLine().Split(';');
                tagok.Add(new Harcos(sor[0], Convert.ToInt32(sor[1])));
            }
            sr.Close();
        }
        static Harcos userCreat()
        {
            int szam = 0;
            string nev = "";
            bool exit = false;
            Console.WriteLine("\nSTATUSZ SABLONOK:\n\t[1] HP:18/18 - DMG: 4\n\t[2] HP:15/15 - DMG: 5\n\t[3] HP:11/11 - DMG: 6");
            do
            {
                Console.Write("\nAdja meg a harcos nevét: ");
                nev = Console.ReadLine();
                Console.Write("\nAdja meg a harcos sablonját: ");
                string beSzam = Console.ReadLine();
                exit = nev != "";
                exit = exit && Int32.TryParse(beSzam, out szam);
                exit = exit && (szam > 0 && szam < 4);
                
            } while (!exit);
            return new Harcos(nev, szam);
        }
        static void Kiir()
        {
            Console.Clear();
            for (int i = 0; i < tagok.Count; i++)
            {
                Console.WriteLine("["+(i+1)+".]...."+tagok[i]);
            }
        }
        static void Main(string[] args)
        {
            tagok = new List<Harcos>() { new Harcos("ZOLTÁÁN", 2), new Harcos("OSzablcs", 1), new Harcos("Zsombor", 3) };
            Beolvas("harcosok.csv");
            Kiir();
            tagok.Add(userCreat());
            Kiir();
        }
    }
}
