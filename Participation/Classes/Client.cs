using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Participation.Classes
{
    class Client
    {
        public bool OvPossibility { get; private set; }
        public List<Request> Requests { get; private set; }
        public string Handicap { get; private set; }        
    }
}
