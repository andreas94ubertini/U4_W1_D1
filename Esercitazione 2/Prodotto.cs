using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione_2
{
    internal class Prodotto
    {
        public string NomeProdotto { get; set; }
        public double Prezzo { get; set; }
        public int Quantita { get; set; }

        public Prodotto() { } 
        public Prodotto(string nomeProdotto, double prezzo, int quantita) 
        { 
            NomeProdotto = nomeProdotto;
            Prezzo = prezzo;
            Quantita = quantita;
        }

        public string CalcolaTotale()
        {
            return "Il costo totale del prodotto è di: " + Prezzo * Quantita + "EUR";
        }
    }
}
