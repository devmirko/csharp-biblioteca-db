
using System.Data.SqlClient;

public class DB_Biblioteca
{
    private static SqlConnection connessione;
    public static void Connect()
    {
        string stringaConnessione = "Data Source=localhost;Initial Catalog=db_biblioteca;Integrated Security=True";
        SqlConnection connessioneSql = new SqlConnection(stringaConnessione);
        connessioneSql.Open();
        connessione = connessioneSql;

    }

    public static void AddToDBLibro(Libri libro)
    {
        DB_Biblioteca.Connect();
        string insertQuery = "INSERT INTO Libro (Titolo,Anno,Stato,Settore,Scaffale,Autore,Codice,Numero_pagine) VALUES (@Titolo,@Anno,@Stato,@Settore,@Scaffale,@Autore,@Codice,@Numero_pagine)";

       SqlCommand insertCommand = new SqlCommand(insertQuery, connessione);
       insertCommand.Parameters.Add(new SqlParameter("@Titolo", libro.Titolo));
       insertCommand.Parameters.Add(new SqlParameter("@Anno", libro.Anno));
       insertCommand.Parameters.Add(new SqlParameter("@Stato",  libro.Stato));
       insertCommand.Parameters.Add(new SqlParameter("@Settore", libro.Settore));
       insertCommand.Parameters.Add(new SqlParameter("@Scaffale", libro.Scaffale));
       insertCommand.Parameters.Add(new SqlParameter("@Autore", libro.Autore));
       insertCommand.Parameters.Add(new SqlParameter("@Codice", libro.Codice));
       insertCommand.Parameters.Add(new SqlParameter("@Numero_pagine", libro.NumeroPagine));



        int affectedRows = insertCommand.ExecuteNonQuery();
        connessione.Close();
    }

    public static void AddToDBDvd(Dvd Dvd)
    {
        DB_Biblioteca.Connect();
        string insertQuery = "INSERT INTO Dvd (Titolo,Anno,Stato,Settore,Scaffale,Autore,Codice,Durata) VALUES (@Titolo,@Anno,@Stato,@Settore,@Scaffale,@Autore,@Codice,@Durata)";

       SqlCommand insertCommand = new SqlCommand(insertQuery, connessione);
       insertCommand.Parameters.Add(new SqlParameter("@Titolo", Dvd.Titolo));
       insertCommand.Parameters.Add(new SqlParameter("@Anno", Dvd.Anno));
       insertCommand.Parameters.Add(new SqlParameter("@Stato",  Dvd.Stato));
       insertCommand.Parameters.Add(new SqlParameter("@Settore", Dvd.Settore));
       insertCommand.Parameters.Add(new SqlParameter("@Scaffale", Dvd.Scaffale));
       insertCommand.Parameters.Add(new SqlParameter("@Autore", Dvd.Autore));
       insertCommand.Parameters.Add(new SqlParameter("@Codice", Dvd.Codice));
       insertCommand.Parameters.Add(new SqlParameter("@Durata", Dvd.Durata));

       int affectedRows = insertCommand.ExecuteNonQuery();
       connessione.Close();
    }

    public static void SearchDocument(string table, string search)
    {
        DB_Biblioteca.Connect();
        string querysearch = "SELECT * FROM " + table + " WHERE Titolo = '" + search + "' OR Codice = '" + search + "'";
        SqlCommand cmd = new SqlCommand(querysearch, connessione);

        SqlDataReader reader = cmd.ExecuteReader();

        int id = 0;
        while (reader.Read())
        {
            id = reader.GetInt32(0);
            string name = reader.GetString(1);
            Console.WriteLine(name);
        }

        connessione.Close();

     
    }

    public static void AllDocument(string table)
    {
        DB_Biblioteca.Connect();
        string querysearch = "SELECT * FROM " + table;
        SqlCommand cmd = new SqlCommand(querysearch, connessione);

        SqlDataReader reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            string name = reader.GetString(1);
            Console.WriteLine(name);

        }
        connessione.Close();
    }

    public static void Delete(string table, string search)
    {
        DB_Biblioteca.Connect();
        string querysearch = "DELETE  FROM " + table +" WHERE Titolo = '" + search + "'";
        SqlCommand cmd = new SqlCommand(querysearch, connessione);

        SqlDataReader reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            string name = reader.GetString(1);
            Console.WriteLine(name);

        }
        connessione.Close();
    }


}