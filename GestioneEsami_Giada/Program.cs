using System;
using System.Collections.Generic;

namespace GestioneEsami_Giada
{
    enum corsiLaurea
    {
        Matematica,
        Fisica,
        Informatica,
        Ingegneria,
        Lettere
    }
    class Program
    {

        static void Main(string[] args)
        {
            //Creo dei Corsi
            //Matematica
            Corsi matematicaI = new Corsi("Matematica I", 9);
            Corsi insiemistica = new Corsi("Insiemistica", 9);
            List<Corsi> corsiMatematica = new List<Corsi>();
            corsiMatematica.Add(matematicaI);
            corsiMatematica.Add(insiemistica);
            //Ingegneria
            Corsi analisiI = new Corsi("Analisi I", 12);
            Corsi algebraLineare = new Corsi("Algebra Lineare", 12); 
            List<Corsi> corsiIngegneria = new List<Corsi>();
            corsiIngegneria.Add(analisiI);
            corsiIngegneria.Add(algebraLineare);
            //Fisica
            Corsi fisicaI = new Corsi("Fisica I", 12);
            Corsi geometria = new Corsi("Geometria", 12);
            List<Corsi> corsiFisica = new List<Corsi>();
            corsiFisica.Add(fisicaI);
            corsiFisica.Add(geometria);
            //Informatica
            Corsi database = new Corsi("DataBase", 9);
            Corsi fondamentiInfo = new Corsi("Fondamenti di Informatica", 12);
            List<Corsi> corsiInformatica = new List<Corsi>();
            corsiInformatica.Add(database);
            corsiInformatica.Add(fondamentiInfo);
            //Lettere
            Corsi letteraturaI = new Corsi("Letteratura Italiana I", 12);
            Corsi filologia = new Corsi("Filologia", 9);
            List<Corsi> corsiLettere = new List<Corsi>();
            corsiLettere.Add(letteraturaI);
            corsiLettere.Add(filologia);

            //Creo i corsi di laurea
            CorsoDiLaurea fisica = new CorsoDiLaurea("Fisica", "3", corsiFisica);
            CorsoDiLaurea matematica = new CorsoDiLaurea("Matematica", "3", corsiMatematica);
            CorsoDiLaurea ingegneria = new CorsoDiLaurea("Ingegneria", "3", corsiIngegneria);
            CorsoDiLaurea Lettere = new CorsoDiLaurea("Lettere", "3", corsiLettere);
            CorsoDiLaurea informatica = new CorsoDiLaurea("Informatica", "3", corsiInformatica);

            //Creo Studente e di conseguenza faccio l'immatricolazione
            Studente marco = new Studente(new Immatricolazione(fisica, false),
                "Marco", "Lomasti", "1996", false);
            
            //Esami
            Esame e1= marco.RichiediEsame("Geometria");
            Console.WriteLine(marco.EsamePassato(e1));

            Esame e2 = marco.RichiediEsame("Fisica I");
            Console.WriteLine(marco.EsamePassato(e2));

            Console.WriteLine("Esami Passati:");
            foreach (Esame e in marco.Esami)
                Console.WriteLine(e.NomeEsame);

            Console.WriteLine("CFU:");
            Console.WriteLine(marco.CFU);

            // Esame e3 = marco.RichiediEsame("FisicaII");
            // Console.WriteLine(marco.EsamePassato(e3));  //Torna un'eccezione 
        }
    }
}
