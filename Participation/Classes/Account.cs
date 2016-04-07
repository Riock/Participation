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
    }
}
