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
                    Console.WriteLine();

                
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
        }
    }
}