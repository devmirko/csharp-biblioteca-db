﻿


/*i vuole progettare un sistema per la gestione di una biblioteca.*/
//Gli utenti si possono registrare al sistema, fornendo:
//cognome,
//nome,
//email,
//password,
//recapito telefonico,

//Gli utenti  possono effettuare dei prestiti sui documenti che sono di vario tipo (libri, DVD).
//I documenti sono caratterizzati da:

//un codice identificativo di tipo stringa (ISBN per i libri, numero seriale per i DVD),
//titolo,
//anno,
//settore(storia, matematica, economia, …),
//stato(In Prestito, Disponibile),
//uno scaffale in cui è posizionato,
//un autore (Nome, Cognome).

//Per i libri si ha in aggiunta il numero di pagine, mentre per i dvd la durata.

//L’utente deve poter eseguire delle ricerche per codice o per titolo e, eventualmente, effettuare dei prestiti registrando il periodo (Dal/Al) del prestito e il documento.
//Deve essere possibile effettuare la ricerca dei prestiti dato nome e cognome di un utente.

public class Libri : Documenti
{

    public int NumeroPagine { get; set; }

    public Libri(string codice, string titolo, int anno, string settore, bool stato, string scaffale, string autore, int numeroPagine) : base(codice, titolo, anno, settore, stato, scaffale, autore)
    {
        NumeroPagine = numeroPagine;


    }

    public override string ToString()
    {
        return "ISBN = " + Codice + "-  Titolo: " + Titolo;
    }

}
