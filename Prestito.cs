
public class Prestito
{
    public string Codice { get; set; }
    public string DataInizio { get; set; }
    public string DataFine { get; set; }


    public Prestito(string codice, string dataInizio, string dataFine)
    {
        Codice = codice;
        DataInizio = dataInizio;
        DataFine = dataFine;


    }

}