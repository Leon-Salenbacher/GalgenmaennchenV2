using GalgenmaennchenV2.Datenbanken;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalgenmaennchenV2.Service
{
    /**
     * Author: Leon Salenbacher
     * stellt sicher, das alle erbenden Klassen eine Datenbank verbindung besitzen.
     */
    public abstract class DBAdapter
    {
        protected MySqlConnector dbConnector;

        public DBAdapter()
        {
            this.dbConnector = new MySqlConnector_MariaDB("galgenmaenchen");
        }
    }
}
