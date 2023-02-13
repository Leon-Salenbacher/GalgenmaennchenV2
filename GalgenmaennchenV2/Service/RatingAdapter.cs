using GalgenmaennchenV2.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalgenmaennchenV2.Service
{
    public class RatingAdapter : DBAdapter
    {

        public void createRating(int userId, int fails, string word)
        {
            Rating rating = new Rating(
                fails,
                word,
                userId
                );

            string sql = "INSERT INTO `galgenmaenchen`.`tbl_ratings` " +
                "(`versuche`, `word`, `tbl_users_ID`) " +
                "VALUES ('" + fails + "', '" + word + "', '" + userId + "');";

            dbConnector.ExecuteNonQuery(sql);
        }

        public Rating getHighScore(string userId)
        {
            return null;


        }
    }
}
