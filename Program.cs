using System;

namespace IDP_assg_3
{
    internal class Program
    {
        public class Grundämne
        {
            public string Namn;
            public int Z;
            public string Typ;
            public double Smältpunkt;
            public double Kokpunkt;
            public Grundämne(string namn, int z, string typ, double smältpunkt, double kokpunkt)
            {
                Namn = namn;
                Z = z;
                Typ = typ;
                Smältpunkt = smältpunkt;
                Kokpunkt = kokpunkt;
            }
            public void Print()
            {
                
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"Grundämne: {Namn.ToUpper()}\n Typ: {Typ}\n Smältpunkt: {Smältpunkt}K\n Kokpunkt: {Kokpunkt}K ");
                    Console.WriteLine($"===================================");

                
            }
        }
        static void Main(string[] args)
        {
            Grundämne syre = new Grundämne("Syre", 8, "ickemetall", 54.36, 90.188);
            Grundämne järn = new Grundämne("Järn", 26, "metall", 1811, 3134);
            Grundämne guld = new Grundämne("Guld", 79, "metall", 1337.33, 3243);

            syre.Print();
            järn.Print();
            guld.Print();

            Grundämne[] grundämnen = new Grundämne[6];

            grundämnen[0] = new Grundämne("Syre", 8, "ickemetall", 54.36, 90.188);
            grundämnen[1] = new Grundämne("Järn", 26, "metall", 1811, 3134);
            grundämnen[2] = new Grundämne("Guld", 79, "metall", 1337.33, 3243);

            grundämnen[3] = new Grundämne("Väte", 1, "ickemetall", 13.99, 20.271);
            grundämnen[4] = new Grundämne("Brom", 35, "ickemetall", 265.8, 332.0);
            grundämnen[5] = new Grundämne("Kvicksilver", 80, "metall", 234.3210, 629.88);

            foreach(Grundämne g in grundämnen)
            {
                g.Print();
            }
            Console.ResetColor();

            Console.ForegroundColor= ConsoleColor.Yellow;
            foreach (Grundämne grundämne in grundämnen)
            {
                if (grundämne.Typ == "metall")
                {
                    Console.WriteLine(grundämne.Namn);
                }
            }
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nGrundämnen som har en smältpunkt under 273.16 K (d.v.s. 0°C) och en kokpunkt över 273.16");
            Console.WriteLine();
            foreach (Grundämne grundämne in grundämnen)
            {
                if (grundämne.Smältpunkt < 273.16 && grundämne.Kokpunkt > 273.16)
                {
                    Console.WriteLine(grundämne.Namn);
                }
            }


            Console.ResetColor();
        }
    }
}