using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneEsami_Giada
{

    class CorsoDiLaurea
    {

        //CAMPI
        public int _CFU = 180;
        //COSTRUTTORE
        public CorsoDiLaurea(string nome, string anni, List<Corsi> corsi)
        {
            Nome = nome
            AnniDiCorsi = anni;
            Corsi = corsi;
        }
        //PROPRIETA'
        public string Nome{ get; }
        public string AnniDiCorsi { get; private set; }
        public List<Corsi> Corsi { get; private set; }
    }
}
