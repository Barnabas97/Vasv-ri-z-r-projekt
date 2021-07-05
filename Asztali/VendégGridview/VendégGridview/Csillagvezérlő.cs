using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace VendégGridview
{
    class Csillagvezérlő
    {
        List<Csillag> csillagok;


        public Csillagvezérlő()
        {
            csillagok = new List<Csillag>();
        }

        public List<Csillag> getCsillagok()
        {
            return csillagok;
        }


        public void beolvasAdatokkatAdatbazisbol()
        {
            if (csillagok.Count > 0)
                csillagok.Clear();
            string connectionString =
                  "SERVER=\"localhost\";"
                + "DATABASE=\"csillagaszat\";"
                + "UID=\"root\";"
                + "PASSWORD=\"\";"
                + "PORT=\"3306\";"
                + "SslMode = None";


            MySqlConnection connection =
                new MySqlConnection(connectionString);
            try
            {
                connection.Open();
            }
            catch (Exception e)
            {


                Debug.WriteLine(e.Message);
                throw new Exception("Sikertelen adatbázismegnyitás");
            }

            string query = "SELECT * FROM  csillag";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    string datum = dr["datum"].ToString();
                    string[] darabok = datum.Split('.');
                    DateTime ido = new DateTime(
                        Convert.ToInt32(darabok[0]),
                        Convert.ToInt32(darabok[1]),
                        Convert.ToInt32(darabok[2]));
                    Csillag cs = new Csillag(
                   Convert.ToInt32(dr["azonosito"]),
                    dr["nev"].ToString(),
                    Convert.ToInt32(dr["eletkor"]),
                    Convert.ToBoolean("oldotte"),
                    ido, Convert.ToInt32(dr["pontszam"]));
                    csillagok.Add(cs);
                }

                dr.Close();
                connection.Close();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw new Exception("Hibás SQL lekérdezés");
            }


        }

        public Csillag getCsillag(int azonosito)
        {
            foreach (Csillag cs in csillagok)
            {
                if (cs.getAzonosito() == azonosito)
                    return cs;
            }
            return null;
        }

        public void modositListabaCsillag(Csillag modositottCsillag)
        {
            foreach (Csillag cs in csillagok)
            {
                if (modositottCsillag.getAzonosito() == cs.getAzonosito())
                {
                    cs.setCsillag(modositottCsillag);


                }
            }

        }
        public void hozzadListabaCsillag(Csillag ujCsillag)
        {
            csillagok.Add(ujCsillag);
        }

        public void torolListabaKaja(int torlendoAzonosito)
        {
            int index = 0;
            foreach (Csillag cs in csillagok)
            {
                if (cs.getAzonosito() == torlendoAzonosito)
                {
                    csillagok.RemoveAt(index);
                    return;
                }

                index++;

            }
        }
    }
}

