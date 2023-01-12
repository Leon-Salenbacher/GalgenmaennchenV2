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
            private int userId;

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

            public int UserId
            {
                get { return userId; }
                set { userId = value; }
            }

            public Rating()
            {

            }

            public Rating(int versuche, string word, int userId)
            {
                this.versuche = versuche;
                this.word = word;
                this.userId = userId;
            }

            public Rating(int id, int versuche, string word, int userId)
            {
                this.versuche = versuche;
                this.word = word;
                this.userId = userId;
                this.id = id;
            }

        }
}
