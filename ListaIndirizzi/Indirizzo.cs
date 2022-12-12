using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaIndirizzi
{
    //proprietà
    public class Indirizzo
    {
        private string nome;
        private string cognome;
        private string via;
        private string citta;
        private string provincia;
        private string cap;

        //costruttori
        public Indirizzo(string nome, string cognome, string via, string citta, string provincia, string cap)
        {
            if (nome == "" || nome == " " || cognome == "" || cognome == " " || via == "" || via == " " || citta == "" || citta == " " || provincia == "" || provincia == " " || cap == "" || cap == " ")
            {
                throw new ArgumentException("Errore: l'indirizzo non è scritto correttamente");
            }
            this.nome = nome;
            this.cognome = cognome;         
            this.via = via;
            this.citta = citta;
            this.provincia = provincia;
            this.cap = cap;
        }

        //getter
        public string GetNome()
        {
            return nome;
        }
        public string GetCognome()
        {
            return cognome;
        }
        public string GetVia()
        {
            return via;
        }
        public string GetCitta()
        {
            return citta;
        }
        public string GetProvincia()
        {
            return provincia;
        }
        public string GetCap()
        {
            return cap;
        }
       
        //metodi
        public override string ToString()
        {
            return "---" + "\nnome: " + nome + "\ncognome: " + cognome + "\nvia: " + via + "\ncittà: " + citta + "\nprovincia: " + provincia + "\ncap: " + cap + "\n---";
        }
    }
}
