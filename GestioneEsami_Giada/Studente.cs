using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneEsami_Giada
{
    class Studente
    {
        //CAMPI
        Immatricolazione _immatricolazione;
        private static List<Esame> _esamiPassati = new List<Esame>();

        //COSTRUTTORE
        public Studente(Immatricolazione imm, string nome, string cognome,
            string annoNascita, bool richiestaLaurea)
        {
            Nome = nome;
            Cognome = cognome;
            AnnoDiNascita = annoNascita;
            RichiestaLaurea = richiestaLaurea;
            _immatricolazione = imm;
        }
        //PROPRIETA'
        //Lista di Esame che mi dice quanti esami ha passato lo studente

        public string Nome { get; private set; }
        public string Cognome { get; private set; }
        public string AnnoDiNascita { get; private set; }
        public List<Esame> Esami
        {
            get
            {
                return _esamiPassati;
            }
        }
        public bool RichiestaLaurea { get; set; }

        public int CFU
        {
            get
            {
                return _immatricolazione.CFUAccumulati;

            }
        }

        //Lo studente può richiedere un'esame
        //solo se
        //è presente 
        //il corso associato a quell'esame fa parte nel corso di laurea
        //CFU non superano i CFU totale
        //Se non ha il flag RichiestaLaurea a VERO

        //METODI
        public Esame RichiediEsame(string esame)
        {
            foreach (Corsi c in _immatricolazione.CorsoDiLaurea.Corsi)
                if (c.NomeEsame == esame
                    && c.CFU < _immatricolazione.CorsoDiLaurea._CFU
                    && !RichiestaLaurea)
                    return new Esame(esame);
                else
                    continue;
            return null;
        }
        public string EsamePassato(Esame esame)
        {
            if (esame == null)
                throw new ArgumentNullException(nameof(Esame), "Esame inestistente nel corso di Laurea");
            else
            {
                _esamiPassati.Add(esame);
                foreach (Esame e in _esamiPassati)
                    _immatricolazione.CfuAccumulati(e.NomeEsame, _immatricolazione.CorsoDiLaurea);

                VerificaRichiestaLaurea(_immatricolazione.CorsoDiLaurea);

                return $"L'Esame di {esame.NomeEsame} è stato inserito Correttamente";
            }
            
        }
        //Controllo che lo studente non abbia tutti i crediti per la richiesta Laurea
        //In questo caso metto Richiesta Laurea true
        public void VerificaRichiestaLaurea(CorsoDiLaurea corsoLaurea)
        {
            if (_immatricolazione.CFUAccumulati == corsoLaurea._CFU)
                RichiestaLaurea = true;
           
        }
    }
}
