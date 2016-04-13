using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Participation.Classes
{
    public class Account
    {
        public int ID { get; set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public string RFID { get; set; }
        public string Username { get; private set; }

        public Account(int id, string username, string email, string password)
        {

            this.ID = id;
            this.Username = username;
            this.Email = email;
            this.Password = password;
        }
        public Account(string username, string email, string password)
            : this(-1, username, email, password)
        {

        }
    }
}
