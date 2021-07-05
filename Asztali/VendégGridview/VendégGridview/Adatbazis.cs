using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConnectToMysqlDatabase;

namespace ConnectToMysqlDatabase
{
    class Adatbazis
    {
        public MySQLDatabaseInterface kapcsolodas()
        {
            MySQLDatabaseInterface mdi = new MySQLDatabaseInterface();
            mdi.setErrorToUserInterface(true);
            mdi.setErrorToGraphicalUserInterface(false);
            mdi.setConnectionServerData("localhost", "zarodolgozat_2018judbar", "3306");
            mdi.setConnectionUserData("root", "");
            mdi.makeConnectionToDatabase();        

            return mdi;
        }
    }
}
