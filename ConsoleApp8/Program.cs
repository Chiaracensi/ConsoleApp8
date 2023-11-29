using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadrato l = new Quadrato();
            Console.WriteLine( " Inserisci il lato del quadrato");
            l.Lato = float.Parse(Console.ReadLine());
            Console.WriteLine(" l'area del quadrato è :", l.Lato * l.Lato);
            Console.Read();
           
        }
    }
}
