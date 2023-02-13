using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalgenmaennchenV2.Service;
using GalgenmaennchenV2.Objects;
using GalgenmaennchenV2.Datenbanken;

namespace galgenmaennchenTest.TestService
{
    [TestClass]
    public class TestRatingAdapter
    {

        [TestMethod]
        public void Test_GetHighScore_goodcase01()
        {
            RatingAdapter ratingAdapter = new RatingAdapter();

            ratingAdapter.getHighScore(1);
        }

        [TestMethod]
        public void create_Rating_goodcase01()
        {
            RatingAdapter ratingAdapter = new RatingAdapter();
            ratingAdapter.createRating(1, 2, "TESTWORD2");
        }

        [TestMethod]
        public void getHighScore()
        {
            RatingAdapter ratingAdapter = new RatingAdapter();
            Rating highscore = ratingAdapter.getHighScore(1);
            
                
                }



        [TestMethod]
        public void Test_Databaseconnection_goodcase01()
        {
            MySqlConnector dbConnector = new MySqlConnector("galgenmaennchen");
            dbConnector.TestConnection();

        }
    }
}
