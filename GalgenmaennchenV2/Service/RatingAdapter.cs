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
     * Beinhaltet alle Funktionen für die verarbeitung einzelner Ratings
     */
    public class RatingAdapter : DBAdapter
    {

        /**
         * Erstellt ein neues Rating
         */
        public void createRating(int userId, int fails, string word)
        {
            //needed???
            Rating rating = new Rating(
                fails,
                word,
                new User()
                );

            string sql = "INSERT INTO `galgenmaenchen`.`tbl_ratings` " +
                "(`versuche`, `word`, `tbl_users_ID`) " +
                "VALUES ('" + fails + "', '" + word + "', '" + userId + "');";

            dbConnector.ExecuteNonQuery(sql);
        }

        /**
         * Returned den Highscore eines Users
         */
        public Rating getHighScore(int userId)
        {
            string sql = "SELECT r.ID as ratingId, MIN(r.versuche) as versuche, r.word, u.ID as userId, u.name " +
                    "FROM galgenmaenchen.tbl_ratings as r " +
                    "INNER JOIN tbl_users as u ON u.ID = r.tbl_users_ID " +
                    "WHERE u.ID = " + userId + " LIMIT 1;";

            MySqlDataReader dataReader = dbConnector.ExecuteQuery(sql);
            dataReader.Read();
            Rating highScore = new Rating(
                    dataReader.GetInt32("ratingId"),
                    dataReader.GetInt32("versuche"),
                    dataReader.GetString("word"),
                    new User(
                            dataReader.GetInt32("userId"),
                            dataReader.GetString("name")
                        )
                );

            dataReader.Close();
            return highScore;
        }
    }
}
