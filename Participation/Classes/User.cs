using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Participation.Classes
{
    class User : Account
    {
        public bool HasCar { get; private set; }
        public bool HasLicence { get; private set; }
        public DateTime Birthdate { get; private set; }
        public DateTime Deregistrationdate { get; private set; }
        public List<Chat> Chats { get; private set; }
        public string Address { get; private set; }
        public string City { get; private set; }
        public string Name { get; private set; }
        public string Phone { get; private set; }
        public string Picture { get; private set; }        
    }
}
