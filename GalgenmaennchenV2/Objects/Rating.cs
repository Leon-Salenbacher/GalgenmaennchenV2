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

            public int Id
            {
                get { return id; }
                set { id = value; }
            }

            public int Versuche
            {
                get { return versuche; }
                set { versuche = value; }
            }

            public string Word
            {
                get { return word; }
                set { word = value; }
            }

            public User User
        {
                get { return user; }
                set { user = value; }
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
