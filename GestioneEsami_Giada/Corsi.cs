using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneEsami_Giada
{
    class Corsi
    {
        //COSTRUTTORE
        public Corsi(string nome, int cfu)
        {
            NomeEsame = nome;
            CFU = cfu;
        }
        //Sono gli esami tipo Analisi
        public string NomeEsame { get; private set; }
        public int CFU { get; private set; }
        //Creo un'esame qui
    }
}
