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
        /* PROVA
        //setter
        public void SetNome(string nome)
        {
            if (nome == "" || nome == " ")
            {
                throw new ArgumentException("nome", "campo del nome errato");
            }
            this.nome = nome;  
        }
        public void SetCognome(string cognome)
        {
            if (cognome == "" || cognome == " ")
            {
                throw new ArgumentException("cognome", "campo del cognome errato");
            }
            this.cognome = cognome;
        }
        public void SetVia(string via)
        {
            if (via == "" || via == " ")
            {
                throw new ArgumentException("via", "campo della via errato");
            }
            this.via = via;
        }
        public void SetCitta(string citta)
        {
            if (citta == "" || citta == " ")
            {
                throw new ArgumentException("citta", "campo della città errato");
            }
            this.citta = citta;
        }
        public void SetProvincia(string provincia)
        {
            if (provincia == "" || provincia == " ")
            {
                throw new ArgumentException("provincia", "campo della provincia errato");
            }
            this.provincia = provincia;
        }
        public void SetCap(string cap)
        {
            if (cap == "" || cap == " ")
            {
                throw new ArgumentException("cap", "campo del cap errato");
            }
            this.cap = cap;
        }
        */
        //metodi
        public override string ToString()
        {
            return "---" + "\nnome: " + nome + "\ncognome: " + cognome + "\nvia: " + via + "\ncittà: " + citta + "\nprovincia: " + provincia + "\ncap: " + cap + "\n---";
        }
       
        /* PROVA
        public override string ToString()
        {
            return "" + nome + "\n" + cognome + "\n" + via + "\n" + citta + "\n" + provincia + "\n" + cap + "\n------";
        }
       */
    }
}
