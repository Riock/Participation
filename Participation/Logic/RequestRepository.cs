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
    }
}
