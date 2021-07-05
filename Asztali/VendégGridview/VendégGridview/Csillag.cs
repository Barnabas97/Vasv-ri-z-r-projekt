using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendégGridview
{
     public class Csillag
     {
        private int azonosito;
        private string nev;
        private int eletkor;
        private bool oldottemármegtesztet;
        private DateTime datum;
        private int pontszam;


        public Csillag(int azonosito, string nev, int eletkor, bool oldottemármegtesztet, DateTime datum, int pontszam)
        {
            this.azonosito = azonosito;
            this.nev = nev;
            this.eletkor = eletkor;
            this.oldottemármegtesztet = oldottemármegtesztet;
            this.datum = datum;
            this.pontszam = pontszam;
        }
        public Csillag(int azonosito)
        {
            this.azonosito = azonosito;
            this.nev = string.Empty;
            this.eletkor = 1;
            this.oldottemármegtesztet = false;
            this.datum = DateTime.Now;
            this.pontszam = 1;

        }

        public int getAzonosito()
        {
            return azonosito;
        }

        public string getNev()
        {
            return nev;
        }
        public int getEletkor()
        {
            return eletkor;
        }

        public bool getOldott()
        {
            return oldottemármegtesztet;
        }

        public DateTime getDatum()
        {
            return datum;
        }

        public int getPontszam()
        {
            return pontszam;
        }



        public void setNev(string nev)
        {
            this.nev = nev;
        }
        public void setEletkor(int eletkor)
        {
            this.eletkor = eletkor;
        }

        public void setOldott(bool oldottemármegtesztet)
        {
            this.oldottemármegtesztet = oldottemármegtesztet;
        }

        public void setDatum(DateTime datum)
        {
            this.datum = datum;
        }

        public void setPontszam(int pontszam)
        {
            this.pontszam = pontszam;
        }

        public void setAzonosito(int azonosito)
        {
            this.azonosito = azonosito;
        }

        public override string ToString()
        {
            return "Azonosito: " + azonosito + ", név:" + nev + ", életkor: " + eletkor + ", dátum:" + datum + ", pontszam:" + pontszam;
        }


        public void setCsillag(Csillag modositottCsillag)
        {
            this.azonosito = modositottCsillag.azonosito;
            this.nev = modositottCsillag.nev;
            this.eletkor = modositottCsillag.eletkor;
            this.oldottemármegtesztet = modositottCsillag.oldottemármegtesztet;
            this.datum = modositottCsillag.datum;
            this.pontszam = modositottCsillag.pontszam;

        }

    }
}
