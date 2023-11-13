using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidomok
{
    internal class Program
    {
        static List<Sikidom> sikidomok = new List<Sikidom>();
        static void Main(string[] args)
        {
            sikidomok.Add(new Kor(5));
            sikidomok.Add(new Kor(4.3));
            sikidomok.Add(new Negyzet(6.2));
            sikidomok.Add(new Teglalap(3, 2));

            foreach (var item in sikidomok)
            {
                if (item.GetType().Equals(typeof(Kor)))
                {
                    Kor kor = (Kor)item; //-- Csak így juthatunk az egyedi adathoz, a sugárhoz
                    Console.WriteLine($"A kör kerülete: {kor.Kerulet()} - területe: {kor.Terulet()} - sugara: {kor.Sugar}");
                    kor.kisebb();
                }
                else if (item.GetType().Equals(typeof(Negyzet)))
                {
                    Negyzet negyzet = (Negyzet)item;
                    Console.WriteLine($"A négyzet oldala: {negyzet.Oldal} hosszú.");
                } else if (item.GetType().Equals(typeof(Teglalap)))
                {
                    Teglalap teglalap = (Teglalap)item;
                    Console.WriteLine($"A téglalap oldalai {teglalap.OldalA} és {teglalap.OldalB} hosszúak");
                }

            }

            Console.WriteLine("program vége");
            Console.ReadLine();
        }
    }
}
