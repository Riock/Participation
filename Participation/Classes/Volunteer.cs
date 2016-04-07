using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Participation.Classes
{
    public class Volunteer : User
    {
        public List<Availability> Availabilities { get; private set; }
        public string VOG { get; private set; }
    }
}
