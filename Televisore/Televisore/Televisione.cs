using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Televisore
{
    internal class Televisione
    {
        const int MaxValue = 99;
        public string Stato { get; set; } = "spenta";
        private int _volume;
        private int _canale;
        public bool Silenzioso { get; set; } = false;

        public int Volume
        {
            get { return _volume; }
            set { _volume = value; }
        }
        public int Canale
        {
            get { return _canale; }
            set { _canale = value; }
        }

        public Televisione(){}
        public Televisione( int volume, int canale)
        {
            Volume = volume;
            Canale = canale;
        }

        public void PulsanteAccensione()
        {
            if (Stato == "spenta")
            {
                Stato = "accesa";
                Console.WriteLine("Televesione accesa");
            }
            else
            {
                Stato = "spenta";
                Console.WriteLine("Televisione spenta");
            }
            
        }
        public void CanaleSuccessivo()
        {
            if (_canale < 99)
            {
                Canale += 1;
                Console.WriteLine("Canale successivo");
            }
            else
            {
                Canale = 1;
            }
        }
        public void CanalePrecedente()
        {
            if(_canale > 0)
            Canale -= 1;
            Console.WriteLine("Canale precedente");
        }
        public void AumentaVolume()
        {
            if (_volume <= 99)
            {
                Volume += 1;
                Console.WriteLine("Volume aumentato");
            }
            else
            {
                Console.WriteLine("Volume già al massimo");
            }

        }
        public void AbbassaVolume()
        {
            if (_volume >= 0)
            {
                Volume -= 1;
                Console.WriteLine("Volume diminuito");
            }
            else
            {
                Console.WriteLine("Volume già al minimo");
            }
        }

        public void ImpostaCanale(int NuovoCanale)
        {
            if(NuovoCanale <= 99 &&  NuovoCanale < 0)
            {
                Canale = NuovoCanale;
            }
        }
        
        public string PrintStatoTv()
        {
            return "La tv è " + Stato;
        }

        public void PulsanteSilezioso()
        {
            if (!Silenzioso)
            {
                Silenzioso = true;
                Volume = 0;
            }
            else
            {
                Silenzioso = false;
                Volume = 20;
            }
        }


    }
}
