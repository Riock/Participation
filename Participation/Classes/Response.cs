using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Participation.Classes
{
    public class Response
    {
        public DateTime Date { get; private set; }
        public string Description { get; private set; }
        public Volunteer Volunteer { get; private set; }
    }
}
