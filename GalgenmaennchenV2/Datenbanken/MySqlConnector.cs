using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalgenmaennchenV2.Datenbanken
{
    public class MySqlConnector
    {
        MySqlConnection dbVerbindung;
        //Variables
        private string dbHost = "localhost";
        private string dbUser = "root";
        private string dbPassword = "";
        private string dbName;
        public MySqlConnector(string databaseName)
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
        private MySqlCommand OpenConnection()
        {
            dbVerbindung = new MySqlConnection(this.ConnectionString);
            dbVerbindung.Open();
            MySqlCommand mysqlCommand = new MySqlCommand();
            mysqlCommand.Connection = dbVerbindung;
            return mysqlCommand;
        }
        private void CloseConnection()
        {
            dbVerbindung.Close();
        }
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
        public int ExecuteNonQuery(String dml)
        {
            int retValue = -1;
            MySqlCommand sqlcommand = this.OpenConnection();
            sqlcommand.CommandText = dml;
            retValue = sqlcommand.ExecuteNonQuery();
            this.CloseConnection();
            return retValue;
        }
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
