using GalgenmaennchenV2.Datenbanken;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalgenmaennchenV2.Service
{
    public class DBAdapter
    {

        protected MySqlConnector dbConnector;

        public DBAdapter()
        {
            this.dbConnector = new MySqlConnector_MariaDB("galgenmaenchen");
        }
    }
}
