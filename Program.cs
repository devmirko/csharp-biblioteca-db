using System.Data.SqlClient;

Console.WriteLine("benvenuti nella biblioteca");


bool exit = true;
DB_Biblioteca.Connect()
do
{
    Console.WriteLine("1 - inserisci un nuovo documento");
    Console.WriteLine("2 - ricerca un documento");
    Console.WriteLine("3 - resgistra un nuovo prestito");
    Console.WriteLine("4 - cerca un prestito");
   
    
    

    string sceltaUtente = Console.ReadLine();
    switch (sceltaUtente)
    {
        case "1":
            SceltaTipo();
            
            break;
        case "2":
            

            break;
        case "3":
            break;
            
        case "4":
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

     Libri libro = new Libri(Codice,Titolo,Anno,Settore,true,Scaffale,Autore,NumeroPagine)
     DB_Biblioteca.AddToDBLibro(libro);
     
    } else if ( risposta == 2 )
    {

     Console.WriteLine("inserisci la durata");
     int Durata = Convert.ToInt32(Console.ReadLine());
     Dvd dvd = new Dvd(Codice,Titolo, Anno, Settore, true, Scaffale, Autore, Durata)
     DB_Biblioteca.AddToDBDvd(dvd);
    


    } else
    {
        throw new Exception("devi scegliere 1 o 2");
        
    }


}







public class DB_Biblioteca
{
    public static void Connect()
    {
        string stringaConnessione = "Data Source = localhost; Initial Catalog = db-biblioteca; Integrated Security = True";
        SqlConnection connessioneSql = new SqlConnection(stringaConnessione);
        connessioneSql.Open();
        connessione = connessioneSql;
    }

    public static void AddToDBLibro(Libri libro)
    {
       string insertQuery = "INSERT INTO Libri (Titolo,Anno,Stato,Settore,Scaffale,Autore,Codice,Numero_pagine) VALUES (@Titolo,@Anno,@Stato,@Settore,@Scaffale,@Autore,@Codice,@Numero_pagine)"

       SqlCommand insertCommand = new SqlCommand(insertQuery, connessione);
       insertCommand.Parameters.Add(new SqlParameter("@Titolo", libro.Titolo));
       insertCommand.Parameters.Add(new SqlParameter("@Anno", libro.Anno));
       insertCommand.Parameters.Add(new SqlParameter("@Stato",  libro.Stato));
       insertCommand.Parameters.Add(new SqlParameter("@Settore", libro.Settore));
       insertCommand.Parameters.Add(new SqlParameter("@Scaffale", libro.Scaffale));
       insertCommand.Parameters.Add(new SqlParameter("@Autore", libro.Autore));
       insertCommand.Parameters.Add(new SqlParameter("@Autore", libro.Codice));
       insertCommand.Parameters.Add(new SqlParameter("@Numero_pagine", libro.Numero_pagine));

        int affectedRows = insertCommand.ExecuteNonQuery();
    }

    public static void AddToDBDvd(Dvd Dvd)
    {
       string insertQuery = "INSERT INTO Dvd (Titolo,Anno,Stato,Settore,Scaffale,Autore,Codice,Durata) VALUES (@Titolo,@Anno,@Stato,@Settore,@Scaffale,@Autore,@Codice,@Durata)"

       SqlCommand insertCommand = new SqlCommand(insertQuery, connessione);
       insertCommand.Parameters.Add(new SqlParameter("@Titolo", Dvd.Titolo));
       insertCommand.Parameters.Add(new SqlParameter("@Anno", Dvd.Anno));
       insertCommand.Parameters.Add(new SqlParameter("@Stato",  Dvd.Stato));
       insertCommand.Parameters.Add(new SqlParameter("@Settore", Dvd.Settore));
       insertCommand.Parameters.Add(new SqlParameter("@Scaffale", Dvd.Scaffale));
       insertCommand.Parameters.Add(new SqlParameter("@Autore", Dvd.Autore));
       insertCommand.Parameters.Add(new SqlParameter("@Autore", Dvd.Codice));
       insertCommand.Parameters.Add(new SqlParameter("@Numero_pagine", Dvd.Durata));

       int affectedRows = insertCommand.ExecuteNonQuery();
    }


}