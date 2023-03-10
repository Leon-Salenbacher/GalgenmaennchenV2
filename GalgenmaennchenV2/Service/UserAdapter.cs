using GalgenmaennchenV2.Datenbanken;
using GalgenmaennchenV2.Objects;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalgenmaennchenV2.Service
{
    /**
     * Author: Leon Salenbacher
     * Beinhaltet alle Funktionen für den User.
     */
    class UserAdapter : DBAdapter
    {
        /**
        * Selecting User by its ID 
        */
        public User getUserById(int userId)
        {
            string sql = "SELECT ID, name FROM tbl_users WHERE ID = " + userId +  ";";

            MySqlDataReader dataReader = dbConnector.ExecuteQuery(sql);
            dataReader.Read();
            User user = new User(
                    dataReader.GetInt32("ID"),
                    dataReader.GetString("name")
                );

            dataReader.Close();
            return user;
        }

        /**
         * Selecting User by its Name
         */
        public User getUserByName(string username)
        {
            string sql = "SELECT ID, name FROM tbl_users WHERE name = '" + username + "';";

            MySqlDataReader dataReader = dbConnector.ExecuteQuery(sql);
            dataReader.Read();
            User user = new User(
                    dataReader.GetInt32("ID"),
                    dataReader.GetString("name")
                );

            dataReader.Close();
            return user;
        }

        /**
         * proofing username and password
         */
        public bool proofSignIn(string username, string password)
        {
            string sql = "SELECT ID, name, password FROM tbl_users WHERE name = '" + username + "';";

            MySqlDataReader dataReader = dbConnector.ExecuteQuery(sql);
            dataReader.Read();
            try
            { 
                User user = new User(
                    dataReader.GetInt32("ID"),
                    dataReader.GetString("name"),
                    dataReader.GetString("password")
                    );

                dataReader.Close();
                return user.isPassword(password);
            }
            catch
            {
                return false;
            }
        }
    }
}
