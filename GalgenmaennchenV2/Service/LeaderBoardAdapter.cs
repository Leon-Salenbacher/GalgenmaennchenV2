﻿using GalgenmaennchenV2.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using GalgenmaennchenV2.Datenbanken;

namespace GalgenmaennchenV2.Service
{
    class LeaderBoardAdapter : DBAdapter
    {

        public List<Rating> getAllRatings_groupedByUser()
        {
            String sql = "SELECT r.ID as ratingID, min(versuche) as highscore, "
                    + "word, name as username, u.ID as userID " 
                    + "FROM galgenmaenchen.tbl_ratings as r " 
                    + "INNER JOIN tbl_users as u ON u.ID = r.tbl_users_ID "
                    + " GROUP BY r.tbl_users_ID order by versuche;";

            MySqlDataReader dataReader = dbConnector.ExecuteQuery(sql);

            List<Rating> allRatings = new List<Rating>();
            while (dataReader.Read())
            {
                Rating rating = new Rating(
                    dataReader.GetInt32("ratingID"),
                    dataReader.GetInt32("highscore"),
                    dataReader.GetString("word"),
                    new User(
                        dataReader.GetInt32("userID"),
                        dataReader.GetString("username")
                        )
                    );
                allRatings.Add(rating);
            }
            return allRatings;
        }

        public List<Rating> getTop10Ratings_groupedByUser()
        {
            String sql = "SELECT r.ID as ratingID, min(versuche) as highscore, "
                    + "word, name as username, u.ID as userID " 
                    + "FROM galgenmaenchen.tbl_ratings as r " 
                    + "INNER JOIN tbl_users as u ON u.ID = r.tbl_users_ID "
                    + " GROUP BY r.tbl_users_ID order by versuche;";

            MySqlDataReader dataReader = dbConnector.ExecuteQuery(sql);

            List<Rating> allRatings = new List<Rating>();
            while (dataReader.Read())
            {
                Rating rating = new Rating(
                    dataReader.GetInt32("ratingID"),
                    dataReader.GetInt32("highscore"),
                    dataReader.GetString("word"),
                    new User(
                        dataReader.GetInt32("userID"),
                        dataReader.GetString("username")
                        )
                    );
                allRatings.Add(rating);
            }
            return allRatings;
        }

        public String ratingsToString(List<Rating> ratings)
        {
            string ratingString = "";
            for(int i = 0; i < ratings.Count(); i++)
            {
                ratingString += (i + 1)+ ": " + ratings[i].getUser().getName() + " " +  ratings[i].getVersuche() +  " \n";
            }

            return ratingString;
        }
    }
}
