using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Participation.Classes
{
    public class Message
    {
        public Account Reciever { get; set; }
        public Account Sender { get; set; }
        public DateTime Date { get; private set; }
        public string Content { get; private set; }//formerly known as Message, renamed due to a conflict with the class name        
    }
}
