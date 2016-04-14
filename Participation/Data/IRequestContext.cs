using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Participation.Classes;

namespace Participation.Data
{
    public interface IRequestContext
    {
        void Cycle(Request request);

        void GetRequestData(Request request);

        Client GetClientByID(Account account);

        void Insert(Account account, string title, string text, string location, DateTime from, DateTime till, bool urgent, Repeat repeat);

        void InsertReview(Account subject, Account author, string Text, DateTime date, int grade);

        List<Response> GetResponses(Request request);

        User GetUser(int id);
    }
}
