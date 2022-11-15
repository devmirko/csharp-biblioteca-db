// See https://aka.ms/new-console-template for more information
using System.Xml;

Console.WriteLine("Hello, World!");


bool exit = true;
DB_Biblioteca.Connect();
do
{
    Console.WriteLine("1 - inserisci un nuovo documento");
    Console.WriteLine("2 - ricerca un documento");
    Console.WriteLine("3 - resgistra un nuovo prestito");
    Console.WriteLine("4 - visualizza tutti i documenti");
   
    
    

    string sceltaUtente = Console.ReadLine();
    switch (sceltaUtente)
    {
        case "1":
            SceltaTipo();
            
            break;
        case "2":
            Console.WriteLine("Cosa vuoi cercare:Libri o Dvd");
            string Response = Console.ReadLine();
            Console.WriteLine("Inserici il titolo o il codice");
            string searchquery = Console.ReadLine();
            DB_Biblioteca.SearchDocument(Response, searchquery);

            break;
        case "3":

            break;
            
        case "4":
            Console.WriteLine("Cosa vuoi visualizzare:Libri o Dvd");
            string search = Console.ReadLine();
            DB_Biblioteca.AllDocument(search);
            Console.WriteLine("Vuoi eliminare qualche documento");
            string risposta = Console.ReadLine();
            if ( risposta == "si")
            {
                Console.WriteLine("inserisci il nome o il titolo");
                string title = Console.ReadLine();
                DB_Biblioteca.Delete(search, title);

            }
            break;
            
        case "5":
           
            break;


        default:
            exit = false;
            break;
    }




} while (exit);

void SceltaTipo()

{
    Console.WriteLine("inserisci");
    Console.WriteLine("1 - per inserire un libro");
    Console.WriteLine("2 - per inserire un dvd");
    int risposta = Convert.ToInt32(Console.ReadLine());
    AddDb(risposta);
}



void AddDb(int risposta)
{


    Console.WriteLine("inserisci il titolo");
    string Titolo = Console.ReadLine();
    Console.WriteLine("inserisci l'anno");
    int Anno = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("inserisci il settore");
    string Settore = Console.ReadLine();
    Console.WriteLine("inserisci lo scaffale");
    string Scaffale = Console.ReadLine();
    Console.WriteLine("inserisci l'autore");
    string Autore = Console.ReadLine();
    Console.WriteLine("inserisci il codice identificativo: ");
    string Codice = Console.ReadLine();

    if ( risposta == 1 ) 
    { 

     Console.WriteLine("inserisci il numero di pagine");
     int NumeroPagine = Convert.ToInt32(Console.ReadLine());

     Libri libro = new Libri(Codice, Titolo, Anno, Settore, true, Scaffale, Autore, NumeroPagine);
     DB_Biblioteca.AddToDBLibro(libro);
     
    } else if ( risposta == 2 )
    {

     Console.WriteLine("inserisci la durata");
     int Durata = Convert.ToInt32(Console.ReadLine());
     Dvd dvd = new Dvd(Codice, Titolo, Anno, Settore, true, Scaffale, Autore, Durata);
     DB_Biblioteca.AddToDBDvd(dvd);
    


    } else
    {
        throw new Exception("devi scegliere 1 o 2");
        
    }


}
