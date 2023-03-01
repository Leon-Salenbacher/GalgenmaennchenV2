﻿using GalgenmaennchenV2.Objects;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalgenmaennchenV2.Service
{
    public class GameAdapter : DBAdapter
    {
        public static int maxLetters = 10;
        public int currentFails = 0;
        public static int maxFails = 10;
        public Game game;
        private RatingAdapter ratingAdapter = new RatingAdapter();
        private List<Letter> getWord()
        {
            string word;
            char[] wordChar = null;
            List<Letter> wordLetters = new List<Letter>();

            do
            {

                string sql = " SELECT word FROM tbl_words "
                        + "ORDER BY RAND() "
                        + "LIMIT 1;";
               
                MySqlDataReader dataReader = dbConnector.ExecuteQuery(sql);
                dataReader.Read();
                word = dataReader.GetString("word");

                dataReader.Close();

                wordChar = word.ToCharArray();

            } while (wordChar.Length > maxLetters);

            for (int i = 0; i < wordChar.Length; i++)
            {
                wordLetters.Add(new Letter(wordChar[i], false));
            }
            return wordLetters;
        }

        public Game startNewGame()
        {
            Game newGame = new Game(getWord());
            this.game = newGame;
            return newGame;
        }

        public String getWordString()
        {
            List<Letter> wordLetters =  this.game.getWordLetters();

            String wordString = "";
            for(int i = 0; i < wordLetters.Count; i++)
            {
                if (wordLetters[i].getIsChecked())
                {
                    wordString += wordLetters[i].getLetter() + " ";
                }
                else
                {
                    wordString += "_ ";
                }
            }

            return wordString;
        }

        public bool proofLetter(char letter)
        {
            for (int i = 0; i < this.game.getWordLetters().Count(); i++)
            {
                Letter curWordLetter = this.game.getWordLetters()[i];
                for (int e = 0; e < this.game.getAlphabet().Count(); e++)
                {
                    Letter curAlphabetLetter = this.game.getAlphabet()[e];

                    //proof if letter is already checked 
                    if (
                        letter.Equals(curWordLetter.getLetter()) &&
                        letter.Equals(curAlphabetLetter.getLetter())
                        )
                    {
                        if (curAlphabetLetter.getIsChecked())
                        {
                            //letter is already checked Error 
                            throw new ArgumentException("Letter already checked");

                        }
                        return true;
                    }
                }
            }
            return false;
        }

        public Game move(char letter)
        {
            if (!this.game.getGameState().Equals(GameState.PLAYING))
            {
                throw new ArgumentException("Game is over");
            }
            if (proofLetter(letter))
            {
                //check letter in word
                this.checkEqualWords(letter);
            }
            else
            {
                //letter isn't in word FAIL
                this.game.addFail();
            }
            //check letter in alphabet
            this.game.setLetterInAlphabetChecked(letter);

            proofGameEnd();
            return this.game;
        }

        public bool proofGameEnd()
        {
            if (this.game.getFails() >= maxFails -1 )
            {
                this.game.setGameState(GameState.LOOS);
                return true;
            }

            for (int i = 0; i < this.game.getWordLetters().Count; i++)
            {
                Letter curLetter = this.game.getWordLetters()[i];
                if (!curLetter.getIsChecked())
                {
                    return false;
                }
            }
            this.game.setGameState(GameState.WIN);
            //TODO handle win 
            return true;
        }

        public void handleGameEnd(int userId)
        {
            if (this.game.getGameState() == GameState.PLAYING)
            {
                throw new ArgumentException("Game is in play");
            }

            if (this.game.getGameState() == GameState.WIN)
            {
                ratingAdapter.createRating(userId, this.game.getFails(), this.game.getWord());
            }

        }


        public Game checkEqualWords(char letter)
        {
            List<Letter> word = this.game.getWordLetters();
            for (int i = 0; i < word.Count(); i++)
            {
                if (letter.Equals(word[i].getLetter()))
                {
                    word[i].setIsChecked(true);
                }
            }
            return this.game;
        }
    }
}
