using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalgenmaennchenV2.Objects
{
        public class Letter
        {

            private char letter;
            private bool isChecked;



            public Letter(char letter, bool isChecked)
            {
                this.letter = letter;
                this.isChecked = isChecked;
            }


            public char getLetter()
            {
                return this.letter;
            }

            public void setLetter(char letter)
            {
                this.letter = letter;
            }

            public bool getIsChecked()
            {
                return this.isChecked;
            }

            public void setIsChecked(bool isChecked)
            {
                this.isChecked = isChecked;
            }
        }
}
