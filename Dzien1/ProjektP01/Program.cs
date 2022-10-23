using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektP01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Clc k = new Clc();

            k.Rozmiar ="duży";

            int wyn = k.Dodaj(1, 2);

            Console.WriteLine(wyn);
            Console.ReadKey();
        }
    }
}
