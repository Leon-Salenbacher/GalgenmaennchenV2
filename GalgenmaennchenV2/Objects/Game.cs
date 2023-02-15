using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalgenmaennchenV2.Objects
{
    public class Game
    {

        private List<Letter> wordLetters;
        private string word;
        private List<Letter> alphabet;
        private GameState gameState;
        private string imgPath;
        private int fails;

        public Game(List<Letter> word)
        {
            this.imgPath = "default";
            this.fails = 0;
            this.gameState = GameState.PLAYING;
            this.wordLetters = word;
            this.word = this.convertToString();
            this.alphabet = newAlphabet();
        }

        private string convertToString()
        {
            string word = "";
            for(int i = 0; i < this.wordLetters.Count(); i++)
            {
                word += this.wordLetters[i].getLetter();
            }
            return word;
        }

        public List<Letter> newAlphabet()
        {
            List<Letter> alphabet = new List<Letter>();

            for (char c = 'A'; c <= 'Z'; c++)
            {
                alphabet.Add(new Letter(c, false));
            }
            return alphabet;
        }

        public void setLetterInAlphabetChecked(char letter)
        {
            for (int i = 0; i < this.getAlphabet().Count; i++)
            {
                Letter curLetter = this.getAlphabet()[i];
                if (curLetter.getLetter().Equals(letter))
                {
                    curLetter.setIsChecked(true);
                }
            }
        }

        public List<Letter> getWordLetters()
        {
            return this.wordLetters;
        }

        public void setWordLetters(List<Letter> wordLetters)
        {
            this.wordLetters = wordLetters;
        }

        public List<Letter> getAlphabet()
        {
            return this.alphabet;
        }

        public void setAlphabet(List<Letter> alphabet)
        {
            this.alphabet = alphabet;
        }


        public string getImgPath()
        {
            return this.imgPath;
        }

        public void setImgPath(string imgPath)
        {
            this.imgPath = imgPath;
        }

        public int getFails()
        {
            return this.fails;
        }

        public void addFail()
        {
            //TODO change imgPath
            this.fails++;
        }

        public void resetFails()
        {
            //TODO change imgPath
            this.fails = 0;
        }

        public GameState getGameState()
        {
            return this.gameState;
        }

        public void setGameState(GameState gameState)
        {
            this.gameState = gameState;
        }

        public void setWord(string word)
        {
            this.word = word;
        }

        public string getWord()
        {
            return this.word;
        }
    }
}
