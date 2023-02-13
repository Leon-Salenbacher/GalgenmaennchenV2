using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalgenmaennchenV2.Objects
{
    public class User
    {
        private String name;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
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
