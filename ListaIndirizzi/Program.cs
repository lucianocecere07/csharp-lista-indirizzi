// See https://aka.ms/new-console-template for more information


using ListaIndirizzi;

List<Indirizzo> listaIndirizzi = new List<Indirizzo>();

try
{
    StreamReader file = File.OpenText("C:\\File Luciano\\Studi\\dotnet generation\\esercizi GIT\\ListaIndirizzi\\ListaIndirizzi\\file\\addresses.csv");
    
    file.ReadLine();
    
    while (!file.EndOfStream)
    {
        string line = file.ReadLine();

        string[] infoIndirizzo = line.Split(",");
        if (infoIndirizzo.Length == 6)
        {
            string nome = infoIndirizzo[0];
            string cognome = infoIndirizzo[1];
            string via = infoIndirizzo[2];
            string citta = infoIndirizzo[3];
            string provincia = infoIndirizzo[4];
            string cap = infoIndirizzo[5];

            Indirizzo indirizzo = new Indirizzo(nome, cognome, via, citta, provincia, cap);
            listaIndirizzi.Add(indirizzo);

        }
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
