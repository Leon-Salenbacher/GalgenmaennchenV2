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
    class UserAdapter : DBAdapter
    {
       
        public User getUser(int userId)
        {
            string sql = "SELECT ID, name FROM tbl_users WHERE ID = 1;";

            MySqlDataReader dataReader = dbConnector.ExecuteQuery(sql);
            dataReader.Read();
            User user = new User(
                    dataReader.GetInt32("ID"),
                    dataReader.GetString("name")
                );

            dataReader.Close();
            return user;
        }

        
    }
}
