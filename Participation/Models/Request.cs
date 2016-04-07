using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Participation.Classes
{
    class Request
    {
        public bool Urgent { get; private set; }
        public Client Client { get; private set; }
        public DateTime From { get; private set; }
        public DateTime Till { get; private set; }
        public List<Response> Responses { get; private set; }
        public string Description { get; private set; }
        public string Location { get; private set; }
        public string Title { get; private set; }        
    }
}
