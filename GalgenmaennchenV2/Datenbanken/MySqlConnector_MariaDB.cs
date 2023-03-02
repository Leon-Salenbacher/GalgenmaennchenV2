using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalgenmaennchenV2.Datenbanken
{
    /**
     * Author: Jonas Tran
     * Stellt die verbindung zur Datenbank
     */
    public class MySqlConnector_MariaDB : MySqlConnector
    {
        //Variabless
        MySqlConnection dbVerbindung;
        private string dbHost = "localhost";
        private string dbUser = "root";
        private string dbPassword = "";
        private string dbName;

        public MySqlConnector_MariaDB(string databaseName)
        {
            this.dbName = databaseName;
        }
        public string _dbHost
        {
            get { return dbHost; }
            set { dbHost = value; }
        }
        public string _dbUser
        {
            get { return dbUser; }
            set { dbUser = value; }
        }
        public string _dbPassword
        {
            get { return dbPassword; }
            set { dbPassword = value; }
        }
        public string _dbName
        {
            get { return dbName; }
            set { dbName = value; }
        }

        private string ConnectionString
        {
            get
            {
                var stringBuilder = new MySqlConnectionStringBuilder();
                stringBuilder.Server = dbHost;
                stringBuilder.UserID = dbUser;
                stringBuilder.Password = dbPassword;
                stringBuilder.Database = dbName;
                return stringBuilder.ConnectionString;
            }
        }

        /**
         * Opening database connection
         */
        private MySqlCommand OpenConnection()
        {
            dbVerbindung = new MySqlConnection(this.ConnectionString);
            dbVerbindung.Open();
            MySqlCommand mysqlCommand = new MySqlCommand();
            mysqlCommand.Connection = dbVerbindung;
            return mysqlCommand;
        }

        /**
         * Closing database connection
         */
        private void CloseConnection()
        {
            dbVerbindung.Close();
        }

        /**
         * Testing Database connection
         */
        public String TestConnection()
        {
            String msg = "DB-Verbindung erfolgreich";
            String sql = "show tables";
            try
            {
                MySqlCommand sqlcommand = this.OpenConnection();
                sqlcommand.CommandText = sql;
                sqlcommand.CommandText = sql;
                sqlcommand.ExecuteReader();
                this.CloseConnection();
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            return msg;
        }

        /**
         * Executing dml
         * returning if its successful
         */
        public int ExecuteNonQuery(String dml)
        {
            int retValue = -1;
            MySqlCommand sqlcommand = this.OpenConnection();
            sqlcommand.CommandText = dml;
            retValue = sqlcommand.ExecuteNonQuery();
            this.CloseConnection();
            return retValue;
        }

        /**
         * Executing sql
         * Returning the result from database
         */
        public MySqlDataReader ExecuteQuery(string sql)
        {
            MySqlDataReader datareader = null;
            MySqlCommand sqlcommand = this.OpenConnection();
            sqlcommand.CommandText = sql;
            datareader = sqlcommand.ExecuteReader();
            return datareader;
        }
    }
}
