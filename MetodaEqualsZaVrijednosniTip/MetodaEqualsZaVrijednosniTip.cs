using System;
using System.Diagnostics;

namespace Vsite.CSharp
{
    public class MetodaEqualsZaVrijednosniTip
    {
        // Definirati da klasa Osoba implementira sučelje IEquatable<Osoba>
        public struct Osoba : IEquatable<Osoba>
        {
            public Osoba(string ime, int matičniBroj)
            {
                m_ime = ime;
                m_matičniBroj = matičniBroj;
            }

            string m_ime;
            int m_matičniBroj;

            // Implementirati metodu Equals(Osoba) iz sučelja IEquatable<Osoba> tako da za osobe s istim imenom i istim matičnim brojem rezultat bude true
            public bool Equals(Osoba other)
            {
                if (!base.Equals(other)) return false;
                if (m_ime != other.m_ime) return false;
                return object.Equals(m_matičniBroj, other.m_matičniBroj);
            }

            // Pregaziti (override) metodu Equals(object) tako da poziva Equals(Osoba)
            public override bool Equals(object obj)
            {
                if (obj == null) return false;
                if (GetType() != obj.GetType()) return false;
                return Equals((Osoba)obj);
            }
            public static bool operator ==(Osoba a, Osoba b)
            {
                return Osoba.Equals(a, b);
            }

            public static bool operator !=(Osoba a, Osoba b)
            {
                return !(a == b);
            }


            public override string ToString()
            {
                return string.Format("'{0}, {1}'", m_ime, m_matičniBroj);
            }

            
        }

        public static void UsporedbaOsoba(Osoba osobaA, Osoba osobaB)
        {
            Console.WriteLine(osobaA);
            Console.WriteLine(osobaB);

            Console.WriteLine(osobaA.Equals(osobaB));
            Console.WriteLine(osobaB.Equals(osobaA));
        }

        static void Main(string[] args)
        {
            // dvije osobe s različitim imenima i MB
            Osoba osobaA = new Osoba("Janko", 1);
            Osoba osobaB = new Osoba("Darko", 2);
            UsporedbaOsoba(osobaA, osobaB);

            // preslika osobe A
            osobaB = osobaA;
            UsporedbaOsoba(osobaA, osobaB);

            // novi "Janko" s istim matičnim brojem
            osobaB = new Osoba("Janko", 1);
            UsporedbaOsoba(osobaA, osobaB);

            // "Janko", ali s drugim matičnim brojem
            osobaB = new Osoba("Janko", 2);
            UsporedbaOsoba(osobaA, osobaB);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
