using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Participation.Classes
{
    public enum Repeat
    {
        Daily, Weekly, Monthly, Never
    }

    public class Request
    {
        public bool Urgent { get; private set; }
        public Client Client { get; private set; }
        public DateTime Date { get;  set; }
        public DateTime FollowupDate { get;  set; }
        public int ID { get; set; }
        public List<Response> Responses { get; private set; }
        public List<string> Tags { get; private set; }
        public string Description { get; private set; }
        public string Location { get; private set; }
        public string Title { get; private set; }
        public Repeat GetRepeat { get { return repeat; } private set {; } }

        private Repeat repeat;
        
        public Request(string title, DateTime dateBegin, bool urgent, string description, Client client, Repeat repeat, List<string> tags)
        {
            this.Title = title;
            this.Date = dateBegin;
            this.Urgent = urgent;
            this.Description = description;
            this.Client = client;
            this.repeat = repeat;
            this.Tags = tags;

            if (repeat == Repeat.Daily)
            {
                this.FollowupDate = this.Date;
                this.FollowupDate.AddDays(1);
            }
            else if (repeat == Repeat.Weekly)
            {
                this.FollowupDate = this.Date;
                this.FollowupDate.AddDays(7);
            }
            else if (repeat == Repeat.Weekly)
            {
                this.FollowupDate = this.Date;
                this.FollowupDate.AddMonths(1);
            }            
        }
    }
}
