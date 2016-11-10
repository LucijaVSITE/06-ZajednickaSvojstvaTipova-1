using System;

namespace Vsite.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pokrenuti program i usporediti ispise. Koja dva znakovna niza daju najbliže brojeve?
//cat.GetHashCode() = 696029510
//cta.GetHashCode() = -419715748
//cap.GetHashCode() = 696029514
//car.GetHashCode() = 696029512
//cut.GetHashCode() = -1985799678
//GOTOVO!!!
//Nema pravila


            Console.WriteLine(string.Format("cat.GetHashCode() = {0}", "cat".GetHashCode()));
            Console.WriteLine(string.Format("cta.GetHashCode() = {0}", "cta".GetHashCode()));
            Console.WriteLine(string.Format("cap.GetHashCode() = {0}", "cap".GetHashCode()));
            Console.WriteLine(string.Format("car.GetHashCode() = {0}", "car".GetHashCode()));
            Console.WriteLine(string.Format("cut.GetHashCode() = {0}", "cut".GetHashCode()));

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
