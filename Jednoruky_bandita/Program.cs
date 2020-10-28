using System;
using System.Net.Sockets;
using System.Security.Authentication.ExtendedProtection;

namespace Jednoruky_bandita
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand1 = new Random();
            Random rand2 = new Random();
            Random rand3 = new Random();
            JednorukyBandita JB = new JednorukyBandita();
            Console.Write("Stav účtu: ");
            JB.Konto=Int32.Parse(Console.ReadLine());
            while (JB.Konto > 0)
            {
                
                do
                {
                    Console.Write("Sázka: ");
                    JB.Sazka = Int32.Parse(Console.ReadLine());
                    
                }
                while (JB.Sazka > JB.Konto);
                JB.Valec1 = (Valec)rand1.Next(5);
                JB.Valec2 = (Valec)rand2.Next(5);
                JB.Valec3 = (Valec)rand3.Next(5);
                Console.WriteLine(JB.Valec1 + " " + JB.Valec2 + " " + JB.Valec3);
                if (JB.Vysledky())
                {
                    JB.Pricteni();
                    Console.WriteLine("Vyhrál jste");
                }
                else
                {
                    JB.Odecteni();
                    Console.WriteLine("Prohrál jste");
                }
                Console.WriteLine("Stav účtu: " + JB.Konto);
            }   

        }
    }
}
