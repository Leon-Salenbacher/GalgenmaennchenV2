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
        /**
         * Executing dml
         * returning if its successful
         */
        int ExecuteNonQuery(String dml);

        /**
         * Executing sql
         * Returning the result from database
         */
        MySqlDataReader ExecuteQuery(string sql);

        /**
         * Testing Database connection
         */
        String TestConnection();
    }
}
