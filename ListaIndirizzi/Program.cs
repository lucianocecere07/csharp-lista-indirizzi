// See https://aka.ms/new-console-template for more information


using ListaIndirizzi;

List<Indirizzo> listaIndirizzi = new List<Indirizzo>();

try
{
    StreamReader file = File.OpenText("C:\\File Luciano\\Studi\\dotnet generation\\esercizi GIT\\ListaIndirizzi\\ListaIndirizzi\\file\\addresses.csv");
    while (!file.EndOfStream)
    {
        string line = file.ReadLine();

        string[] infoIndirizzo = line.Split(",");

        string nome = infoIndirizzo[0];
        string cognome = infoIndirizzo[1];
        string via = infoIndirizzo[2];
        string citta = infoIndirizzo[3];
        string provincia = infoIndirizzo[4];
        string cap = infoIndirizzo[5];

        Indirizzo indirizzo = new Indirizzo(nome, cognome, via, citta, provincia, cap);
        listaIndirizzi.Add(indirizzo);
    }
    file.Close();
}
catch (ArgumentException e)
{
    Console.WriteLine(e.Message);
}

foreach (Indirizzo indirizzo in listaIndirizzi)
{
    Console.WriteLine(indirizzo);
}


//------//

/*  PROVA
//"C:\\File Luciano\\Studi\\dotnet generation\\esercizi GIT\\ListaIndirizzi\\ListaIndirizzi\\file\\addresses.csv"
//"C:\\File Luciano\\Studi\\dotnet generation\\esercizi-prove non su github\\prove-VS2022\\documento.txt"
*/