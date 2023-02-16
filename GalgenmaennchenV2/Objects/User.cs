using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalgenmaennchenV2.Objects
{
    public class User
    {
        private string name;

        public string getName()
        {
            return this.name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        private string password;

        private void setPassword(string password)
        {
            this.password = password;
        }

        public bool isPassword(string password)
        {
            if (this.password.Equals(password))
            {
                return true;
            }

            return false;
        }

        private int id;

        private int getId()
        {
            return this.id;
        }

        private void setId(int id)
        {
            this.id = id;
        }

        public User()
        {

        }

        public User(String name, String password)
        {
            this.name = name;
            this.password = password;
        }

        public User(int id, String name)
        {
            this.id = id;
            this.name = name;
        }

        public User(int id, String name, String password)
        {
            this.id = id;
            this.name = name;
            this.password = password;
        }


    }
}
