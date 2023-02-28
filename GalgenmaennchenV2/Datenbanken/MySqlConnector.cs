using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GalgenmaennchenV2.Datenbanken
{
    public interface MySqlConnector
    {
        int ExecuteNonQuery(String dml);
        MySqlDataReader ExecuteQuery(string sql);
    }
}
