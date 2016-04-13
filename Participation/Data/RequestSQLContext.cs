using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Participation.Classes;
using Participation.Data;
using Oracle.DataAccess.Client;

namespace Participation.Data
{
    public class RequestSQLContext : IRequestContext
    {
        public void Cycle(Request request)
        {
            throw new NotImplementedException();
        }

        public Client GetClientByID(Account account)
        {
            Client ret;

            //try
            //{
            //    database.OpenConnection();
            //    database.Query = "select a.username, a.email, u.name, a.password, u.phone, u.adress, u.housenumber, u.city, u.zipcode, u.hascar, u.haslicence, u.birthdate, u.picture, u.usertype, c.OVPossibility, c.handicap  
            //    from CLIENT c, USERINFO u, ACCOUNT a where c.accountid = u.accountid and u.accountid = a.accountid and c.ACCOUNTID = :id"; 

            //    database.Command.Parameters.Add(new OracleParameter("id", account.ID));


            //    database.Command.ExecuteNonQuery();
            //}
            //catch (OracleException e)
            //{
            //    MessageBox.Show(e.Message);
            //    throw;
            //}
            //finally
            //{
            //    database.Commit();
            //    database.CloseConnection();
            //}

            List<string> Queryresult = new List<string>();
            bool retCar;
            bool retLicence;
            bool retOV;
            DateTime retDate;

            retDate = Convert.ToDateTime(Queryresult[11]);

            if (Queryresult[9] == "0")
            {
                retCar = false;
            }
            else
            {
                retCar = true;
            }
            if (Queryresult[10] == "0")
            {
                retLicence = false;
            }
            else
            {
                retLicence = true;
            }
            if (Queryresult[14] == "0")
            {
                retOV = false;
            }
            else
            {
                retOV = true;
            }

            ret = new Client(account.ID, Queryresult[0], Queryresult[1], Queryresult[2], Queryresult[3], Queryresult[4], Queryresult[5], Convert.ToInt32(Queryresult[6]), Queryresult[7], Queryresult[8], retCar, retLicence, retDate /*dataformat?*/, Queryresult[12] /*byte?*/, Queryresult[13], retOV, Queryresult[15]);
            return ret;
        }

        public void GetCurrentRequestData()
        {
            throw new NotImplementedException();
        }

        public void Insert(Account account, string title, string text, string location, DateTime from, DateTime till, bool urgent, Repeat repeat)
        {
            //            insert into REQUEST(AccountID, Title, Text, Location, FromWhen, Till, Urgent, RequestRepeat)
            //values(:id, :title, :text, :location, :fromwhen, :till, :urgent, :repeatreq);

            string _id = Convert.ToString(account.ID);
            string _from = from.ToString();
            string _till = till.ToString();
            string _urgent = "0";
            if (urgent)
            {
                _urgent = "1";
            }

            throw new NotImplementedException();
        }

        public void InsertReview(Account subject, Account author, string Text, DateTime date, int grade)
        {
            //            insert into REVIEW(AccountIDA, AccountIDB, Text, ReviewDate, Grade)
            //values(:IDA, :IDB, :Text, :RDate, :Grade);

            string _IDA = Convert.ToString(subject.ID);
            string _IDB = Convert.ToString(author.ID);
            string _RDate = date.ToString();
            string _Grade = Convert.ToString(grade);

            throw new NotImplementedException();
        }
    }
}
