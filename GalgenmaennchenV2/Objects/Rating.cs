using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalgenmaennchenV2.Objects
{
        public class Rating
        {
            private int id;
            private int versuche;
            private string word;
            private User user;


            public int getId()
        {
            return this.id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

            public int getVersuche()
        {
            return this.versuche;
        }

        public void setVersuche(int versuche)
        {
            this.versuche = versuche;
        }


        public string getWord()
        {
            return this.word;

        }

        public void setWord(string word)
        {
            this.word = word;
        }


        public User getUser()
        {
            return this.user;
        }

        public void setUser(User user)
        {
            this.user = user;
        }
            public Rating()
            {

            }

            public Rating(int versuche, string word, User user)
            {
                this.versuche = versuche;
                this.word = word;
                this.user = user;
            }

            public Rating(int id, int versuche, string word, User user)
            {
                this.versuche = versuche;
                this.word = word;
                this.user = user;
                this.id = id;
            }

        }
}
