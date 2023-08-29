using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Televisore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Televisione televisione = new Televisione();
            televisione.PulsanteAccensione();
            televisione.PulsanteAccensione();
            televisione.ImpostaCanale(5);
            televisione.CanaleSuccessivo();
            Console.Write(televisione.PrintStatoTv());
            Console.ReadLine();
        }
    }
}
