using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GalgenmaennchenV2.Service;
using GalgenmaennchenV2.Objects;
using System.Collections.Generic;

namespace galgenmaennchenTest.TestService
{
    [TestClass]
    public class TestGameAdapter
    {
        [TestMethod]
        public void Test_GetWord_goodcase01()
        {
            int expected_length = 5;
            GameAdapter g = new GameAdapter();
            Game game = g.startNewGame();

            // assert
            List<Letter> word = game.getWordLetters();
            int actual_Length = word.Count;
            Assert.AreEqual(expected_length, actual_Length);
        }

        [TestMethod]
        public void Test_ProofLetter_goodcase01()
        {
            GameAdapter g = new GameAdapter();
            Game game = g.startNewGame();

            bool res = g.proofLetter('H');

            Assert.AreEqual(true, res);
        }

        [TestMethod]
        public void Test_move_goodcase01()
        {
            GameAdapter g = new GameAdapter();
            Game game = g.startNewGame();

            game = g.move('H');

            //not testing test manuel in debug
            Assert.AreEqual(true, game);
        }
    }
}
