using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Participation.Data;
using Participation.Classes;

namespace Participation.Logic
{
    public class RequestRepository
    {
        private IRequestContext context;

        public RequestRepository(IRequestContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// Update de datums, zodat de From en Till kloppen. Voer dit uit als de hulpvraag geweest is
        /// </summary>
        public void Cycle(Request request)
        {
            request.Date = request.FollowupDate;

            if (request.GetRepeat == Repeat.Daily)
            {
                request.FollowupDate.AddDays(1);
            }
            else if (request.GetRepeat == Repeat.Weekly)
            {
                request.FollowupDate.AddDays(7);
            }
            else if (request.GetRepeat == Repeat.Weekly)
            {
                request.FollowupDate.AddMonths(1);
            }
        }

        //public void AddRequest(string title, DateTime date, bool urgent, string description, Client client, string repeat, string tagsString)
        //{
        //    Repeat rep;
        //    List<string> tags = new List<string>();

        //    if (repeat == Repeat.Daily.ToString())
        //    {
        //        rep = Repeat.Daily;
        //    }
        //    else if (repeat == Repeat.Weekly.ToString())
        //    {
        //        rep = Repeat.Weekly;
        //    }
        //    else if (repeat == Repeat.Monthly.ToString())
        //    {
        //        rep = Repeat.Monthly;
        //    }
        //    else
        //    {
        //        rep = Repeat.Never;
        //    }

        //    tags = tagsString.Split(',').ToList<string>();
        //}

        public Client GetClientByID(Account account)
        {
            return context.GetClientByID(account);
        }

        public void Insert(Account account, string title, string text, string location, DateTime from, DateTime till, bool urgent, Repeat repeat)
        {
            context.Insert(account, title, text, location, from, till, urgent, repeat);
        }

        public List<Response> GetResponses(Request request)
        {
            return context.GetResponses(request);
        }
    }
}
