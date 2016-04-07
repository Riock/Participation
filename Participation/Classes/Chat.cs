using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Participation.Classes
{
    public class Chat
    {
        public Client Client { get; private set; }
        public List<Message> Messages { get; private set; }
        public Volunteer Volunteer { get; private set; }

        //test
        public List<Message> GetMessages(DateTime from, DateTime till)
        {
            return null;
        }
    }
}
