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
        public int ID { get; private set; }
        public Request Request { get; private set; }
        public string Description { get; private set; }
        public User Author { get; private set; }

        public Response(DateTime date, int id, Request request, string description, User author)
        {
            this.Date = date;
            this.ID = id;
            this.Request = request;
            this.Description = description;
            this.Author = author;
        }

        public override string ToString()
        {
            return Author.Name + Date.ToString() + Description;
        }
    }
}
