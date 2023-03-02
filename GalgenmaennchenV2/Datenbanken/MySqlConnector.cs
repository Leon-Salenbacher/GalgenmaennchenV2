using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GalgenmaennchenV2.Datenbanken
{
    /**
     * Author: Leon Salenbacher
     * Interface um sicher zustellen, das alle MySqlConnectors diese funktionen implementieren
     */
    public interface MySqlConnector
    { 
        int ExecuteNonQuery(String dml);
        MySqlDataReader ExecuteQuery(string sql);
        String TestConnection();
    }
}
