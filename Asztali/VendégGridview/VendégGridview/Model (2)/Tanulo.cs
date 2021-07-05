using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendégGridview.Model
{
    class Tanulo
    {
        private int felhasznaloid;
        private string felhasznalonev;
        private int osszpontszam;
        private DateTime datum;
        private int tesztszam;



        public Tanulo(int felhasznaloid, string felhasznalonev, int osszpontszam, DateTime datum, int tesztszam)
        {
            this.felhasznaloid = felhasznaloid;
            this.felhasznalonev = felhasznalonev;
            this.osszpontszam = osszpontszam;
            this.datum = datum;
            this.tesztszam = tesztszam;
        }

        public int getFelhasznaloid()
        {
            return felhasznaloid;
        }

        public string getFelhasznalonev()
        {
            return felhasznalonev;
        }

        public int getOsszpontszam()
        {
            return osszpontszam;
        }

        public DateTime getDatum()
        {
            return datum;
        }

        public int getTesztszam()
        {
            return tesztszam;
        }

        public void setFelhasznalonev(string felhasznalonev)
        {
            this.felhasznalonev = felhasznalonev;
        }


        public void setOsszpontszam(int osszpontszam)
        {
            this.osszpontszam = osszpontszam;
        }

        public void setDatum(DateTime datum)
        {
            this.datum =datum;
        }

        public void setTesztszam(int tesztszam)
        {
            this.tesztszam = tesztszam;
        }

        public void update(Tanulo tanulo)
        {
            this.felhasznaloid = tanulo.getFelhasznaloid();
            this.felhasznalonev = tanulo.getFelhasznalonev();
            this.osszpontszam = tanulo.getOsszpontszam();
            this.datum = tanulo.getDatum();
            this.tesztszam = tanulo.getTesztszam();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }

   
}
