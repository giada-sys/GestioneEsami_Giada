using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneEsami_Giada
{
    class Immatricolazione
    {
        //CAMPO 
        public int CFUAccumulati = 0;
        public Immatricolazione(CorsoDiLaurea corso, bool fuoriCorso)
        {
            //Genero la matricola
            Random r = new Random();
            string m = "s";
            for (int i = 0; i <= 7; i++)
                m += r.Next(0, 9);
            Matricola = m;
            DataInizio = DateTime.Today;
            CorsoDiLaurea = corso;
            FuoriCorso = fuoriCorso;
        }
        public string Matricola { get; private set; }
        public DateTime DataInizio { get; private set; }
        public CorsoDiLaurea CorsoDiLaurea { get; private set; }
        public bool FuoriCorso { get; set; }

        public int CfuAccumulati(string e, CorsoDiLaurea corsoLaurea)
        {
            foreach (Corsi c in corsoLaurea.Corsi)
            {
                if (e == c.NomeEsame)
                    CFUAccumulati += c.CFU;
            }
            return CFUAccumulati;
        }

    }
}
