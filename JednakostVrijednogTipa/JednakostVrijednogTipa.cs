using System;

namespace Vsite.CSharp
{
    using Osoba = Vsite.CSharp.MetodaEqualsZaVrijednosniTip.Osoba;

    public class JednakostVrijednogTipa
    {
        public static void Jednakost(Osoba osobaA, Osoba osobaB)
        {
            // Otkomentirati donje naredbe i provjeriti može li se kod prevesti i izvesti.
            Console.WriteLine(string.Format("{0} == {1}: {2}", osobaA, osobaB, osobaA == osobaB));
            Console.WriteLine(string.Format("{0} != {1}: {2}", osobaA, osobaB, osobaA != osobaB));
//'Janko, 1' == 'Janko, 1': True
//'Janko, 1' != 'Janko, 1': False
//'Janko, 1' == 'Janko, 1': True
//'Janko, 1' != 'Janko, 1': False
//'Janko, 1' == 'Darko, 2': False
//'Janko, 1' != 'Darko, 2': True
//'Janko, 1' == 'Janko, 2': False
//'Janko, 1' != 'Janko, 2': True
//GOTOVO!!!

            // TODO: Strukturi Osoba u projektu MetodaEqualsZaVrijednosniTip definirati operatore == i != tako da donji primjeri daju očekivane rezultate.
        }

        static void Main(string[] args)
        {

            // dvije osobe s različitim imenima i MB
            Osoba osobaA = new Osoba("Janko", 1);
            Osoba osobaB = osobaA;
            Jednakost(osobaA, osobaB);

            osobaB = new Osoba("Janko", 1);
            Jednakost(osobaA, osobaB);

            osobaB = new Osoba("Darko", 2);
            Jednakost(osobaA, osobaB);

            osobaB = new Osoba("Janko", 2);
            Jednakost(osobaA, osobaB);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
