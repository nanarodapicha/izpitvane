using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace izpitvane
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Letishte samolet = new Letishte("Sofiq", 19734);
                samolet.Print();
                List<Letishte> letishta = new List<Letishte>();
                Console.Write("Vuvedi broi obekti:");
                int n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    Console.Write("Vuvedi destinaciq: ");
                    string destinaciq = Console.ReadLine();

                    Console.Write("Vuvedi kod na poleta: ");
                    int kod = int.Parse(Console.ReadLine());

                    Console.Write("Vuvedi chas na poleta:");
                    double chas = double.Parse(Console.ReadLine());

                    Console.Write("Vuvedi data na poleta: ");
                    double data = double.Parse(Console.ReadLine());
                    Console.WriteLine();

                    Letishte samolett = new Letishte(destinaciq, kod, chas, data);
                    letishta.Add(samolett);


                }
                var slist = letishta.OrderBy(x => x.Kod);
                var sslist = letishta.OrderBy(x => x.Destinaciq);
                foreach (var h in slist)
                {
                    Console.WriteLine(h);
                }
                Console.WriteLine();
                foreach (var hh in sslist)
                {
                    Console.WriteLine(hh);
                }
                Console.Write("Vuvedi datata na koqto tursish polet: ");
                double datta = double.Parse(Console.ReadLine());
                var poletdata = letishta.Where(x => x.Data == datta);

                if (poletdata.Count() > 0)
                {
                    Console.WriteLine($"Poleti na data{datta}:");
                    foreach (var f in poletdata)
                    {
                        Console.WriteLine(f);
                    }
                }
                else
                {
                    Console.WriteLine("Nqma poleti na tazi data.");
                }
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}
