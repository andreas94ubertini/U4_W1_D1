using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Inserisci Nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Inserisci Cognome:");
            string cognome = Console.ReadLine();
            Console.WriteLine("Inserisci Età:");
            int eta = Convert.ToInt32(Console.ReadLine());
            Persona persona = new Persona(nome, cognome, eta);
            Console.WriteLine(persona.GetDettagli());
            Console.ReadLine();
            Console.ReadLine();
            Console.WriteLine("Inserisci il nome del prodotto:");
            string nomeProdotto = Console.ReadLine();
            Console.WriteLine("Inserisci il prezzo del prodotto:");
            double prezzoProdotto = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Inserisci la quantità:");
            int quantita = Convert.ToInt32(Console.ReadLine());
            Prodotto prodotto = new Prodotto(nomeProdotto, prezzoProdotto, quantita);
            Console.WriteLine(prodotto.CalcolaTotale());
            Console.ReadLine();
            //prova commento
        }
    }
}
